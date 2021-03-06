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
    public class Link4Model : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private HrefModel self;
        private HrefModel clarifyMetadata;
        private HrefModel clarifyTracks;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("self")]
        public HrefModel Self 
        { 
            get 
            {
                return this.self; 
            } 
            set 
            {
                this.self = value;
                onPropertyChanged("Self");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("clarify:metadata")]
        public HrefModel ClarifyMetadata 
        { 
            get 
            {
                return this.clarifyMetadata; 
            } 
            set 
            {
                this.clarifyMetadata = value;
                onPropertyChanged("ClarifyMetadata");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("clarify:tracks")]
        public HrefModel ClarifyTracks 
        { 
            get 
            {
                return this.clarifyTracks; 
            } 
            set 
            {
                this.clarifyTracks = value;
                onPropertyChanged("ClarifyTracks");
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