/*
 * Clarify.PCL
 *
 * This file was automatically generated by APIMATIC BETA v2.0 on 10/06/2014
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Clarify.PCL;

namespace Clarify.PCL.Models
{
    public class ClarifyBaseModel : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string bundleId;
        private int version;
        private string status;
        private string created;
        private string updated;
        private string mClass;
        private Link2Model mLinks;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("bundle_id")]
        public string BundleId 
        { 
            get 
            {
                return this.bundleId; 
            } 
            set 
            {
                this.bundleId = value;
                onPropertyChanged("BundleId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("version")]
        public int Version 
        { 
            get 
            {
                return this.version; 
            } 
            set 
            {
                this.version = value;
                onPropertyChanged("Version");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("status")]
        public string Status 
        { 
            get 
            {
                return this.status; 
            } 
            set 
            {
                this.status = value;
                onPropertyChanged("Status");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("created")]
        public string Created 
        { 
            get 
            {
                return this.created; 
            } 
            set 
            {
                this.created = value;
                onPropertyChanged("Created");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("updated")]
        public string Updated 
        { 
            get 
            {
                return this.updated; 
            } 
            set 
            {
                this.updated = value;
                onPropertyChanged("Updated");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("_class")]
        public string MClass 
        { 
            get 
            {
                return this.mClass; 
            } 
            set 
            {
                this.mClass = value;
                onPropertyChanged("MClass");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("_links")]
        public Link2Model MLinks 
        { 
            get 
            {
                return this.mLinks; 
            } 
            set 
            {
                this.mLinks = value;
                onPropertyChanged("MLinks");
            }
        }

        /// <summary>
        /// Property changed event for observer pattern
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises event when a property is changed
        /// </summary>
        /// <param name="propertyName">Name of the changed property</param>
        protected void onPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
} 