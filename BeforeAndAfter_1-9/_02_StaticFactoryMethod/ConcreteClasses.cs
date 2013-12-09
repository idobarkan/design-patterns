using System;
using System.Collections.Generic;
using System.Text;

namespace _02_StaticFactoryMethod
{
    public abstract class FullName
    {
        public static FullName Create(string i_FullName)
        {
            /// NOTE:
            /// This code could be easily replaced with
            /// a code that reads a configuration file
            /// which holds inforamtion (that can be updated/modified)
            /// regarding which instance to create in respect to i_FullName

            int i = i_FullName.IndexOf(",");
            if (i > 0)
            {
                return new FullName_En_US(i_FullName);
            }
            else
            {
                return new FullName_He_IL(i_FullName);
            }
        }

        protected string m_FirstName;
        public string FirstName
        {
            get { return m_FirstName; }
            set { m_FirstName = value; }
        }

        protected string m_LastName;
        public string LastName
        {
            get { return m_LastName; }
            set { m_LastName = value; }
        }
    }

    public class FullName_En_US : FullName
    {
        public FullName_En_US(string i_FullName)
        {
            int i = i_FullName.IndexOf(",");
            if (i > 0)
            {
                m_LastName = i_FullName.Substring(0, i);
                m_FirstName = i_FullName.Substring(i + 1).Trim();
            }
            else
            {
                m_LastName = i_FullName;
                m_FirstName = string.Empty;
            }
        }
    }

    public class FullName_He_IL : FullName
    {
        public FullName_He_IL(string i_FullName)
        {
            int i = i_FullName.IndexOf(" ");
            if (i > 0)
            {
                m_FirstName = i_FullName.Substring(0, i).Trim();
                m_LastName = i_FullName.Substring(i + 1).Trim();
            }
            else
            {
                m_LastName = i_FullName;
                m_FirstName = "";
            }
        }
    }
}
