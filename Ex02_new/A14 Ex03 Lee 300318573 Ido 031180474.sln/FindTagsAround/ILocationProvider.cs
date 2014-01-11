﻿namespace FindTagsAround
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using FacebookWrapper.ObjectModel;

    public interface ILocationProvider
    {
        Coordinate GetLocationCoordinates(string i_googleMapsReference);
        
        List<GoogleMapsReference> GetLocationSuggestions(string userInput);
    }
}
