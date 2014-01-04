using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using System.Net;
using System.Xml.Linq;
using System.Xml;
using System.IO;

namespace FindTagsAround
{

    public class GoogleMapsFacade : ILocationProvider
    {
        private string m_GoogleMapsKey = "AIzaSyBYpkC0V-CGuJX1pDC8Rr8nuF4ISACDjiE";

        public Coordinate GetLocationCoordinates(string i_GoogleMapsReference)
        {
            Stream responseStream = getLocationResponseStream(i_GoogleMapsReference);
            return getLocationFromResponseXml(responseStream);
        }

        public List<GoogleMapsReference> GetLocationSuggestions(string i_LocationSearchString)
        {
            Stream responseStream = getSuggestionsResponseStream(i_LocationSearchString);
            List<GoogleMapsReference> result = getSuggestionsFromResponseXml(responseStream);
            return result;
        }

        public Coordinate GetFeelingLuckyCoordinate(string i_LocationSearchString)
        {
            Stream responseStream = getSuggestionsResponseStream(i_LocationSearchString);
            List<GoogleMapsReference> result = getSuggestionsFromResponseXml(responseStream);
            return GetLocationCoordinates(result.First().Reference);
        }

        private Stream getLocationResponseStream(string i_LocationReference)
        {
            string requestUri = string.Format(
                "https://maps.googleapis.com/maps/api/place/details/xml?reference={0}&sensor=false&key={1}",
                Uri.EscapeDataString(i_LocationReference),
                m_GoogleMapsKey);

            return sendRequestAndGetResponseStream(requestUri);
        }

        private Stream sendRequestAndGetResponseStream(string requestUri)
        {
            var request = WebRequest.Create(requestUri);
            var response = request.GetResponse();
            return response.GetResponseStream();
        }

        private Stream getSuggestionsResponseStream(string userInput)
        {
            var requestUri = string.Format(
                "https://maps.googleapis.com/maps/api/place/autocomplete/xml?input={0}&language=en&sensor=false&key={1}",
                Uri.EscapeDataString(userInput),
                m_GoogleMapsKey);

            return sendRequestAndGetResponseStream(requestUri);
        }

        private List<GoogleMapsReference> getSuggestionsFromResponseXml(Stream xmlStream)
        {
            XDocument xdoc = XDocument.Load(xmlStream);
            var result = new List<GoogleMapsReference>();
            foreach (var prediction in xdoc.Descendants("prediction"))
            {
                string reference = prediction.Descendants("reference").Select(x => x.Value).Single();
                string description = prediction.Descendants("description").Select(x => x.Value).Single();
                result.Add(new GoogleMapsReference(){Description=description, Reference=reference});
            }
            return result;
        }

        private Coordinate getLocationFromResponseXml(Stream xmlStream)
        {
            XDocument xdoc = XDocument.Load(xmlStream);
            List<GoogleMapsReference> result = new List<GoogleMapsReference>();
            XElement location = xdoc.Descendants("location").Select(x => x).Single();
            string lat = location.Descendants("lat").Select(x => x.Value).Single();
            string lng = location.Descendants("lng").Select(x => x.Value).Single();
            double parsedLat;
            double parsedLong;
            if (!Double.TryParse(lat, out parsedLat) 
                || !Double.TryParse(lng, out parsedLong))
            {
                throw new Exception("error in parsing geometry");
            }
            return new Coordinate(parsedLat, parsedLong);
        }
    }
}
