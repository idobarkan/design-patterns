using System;
using System.Collections.Generic;
using System.Text;

namespace _03_StaticFactoryClass
{
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
