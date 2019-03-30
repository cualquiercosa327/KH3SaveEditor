﻿/*
    Kingdom Hearts Save Editor
    Copyright (C) 2019 Luciano Ciccariello

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

using System.Linq;

namespace KHSave.Attributes
{
    public class MapInfoAttribute : InfoAttribute
    {
        public string Id { get; set; }

        public MapInfoAttribute(string id, string name) :
            base(string.IsNullOrEmpty(name) ? id : name)
        {
            Id = id;
        }

        public static string GetMapId(object value)
        {
            var memberValue = value.ToString();
            var memberInfo = value.GetType().GetMember(memberValue).FirstOrDefault();

            if (memberInfo != null)
            {
                if (memberInfo.GetCustomAttributes(typeof(MapInfoAttribute), false)
                        .FirstOrDefault() is MapInfoAttribute attribute && !string.IsNullOrEmpty(attribute.Info))
                {
                    return attribute.Id;
                }
            }

            return null;
        }
    }
}
