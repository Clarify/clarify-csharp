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
    public class SearchResponseModel : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private int total;
        private int limit;
        private List<SearchTermModel> searchTerms;
        private List<ItemResultModel> itemResults;
        private string mClass;
        private Link2Model mLinks;
        private EmbededListModel mEmbedded;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("total")]
        public int Total 
        { 
            get 
            {
                return this.total; 
            } 
            set 
            {
                this.total = value;
                onPropertyChanged("Total");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("limit")]
        public int Limit 
        { 
            get 
            {
                return this.limit; 
            } 
            set 
            {
                this.limit = value;
                onPropertyChanged("Limit");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("search_terms")]
        public List<SearchTermModel> SearchTerms 
        { 
            get 
            {
                return this.searchTerms; 
            } 
            set 
            {
                this.searchTerms = value;
                onPropertyChanged("SearchTerms");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("item_results ")]
        public List<ItemResultModel> ItemResults 
        { 
            get 
            {
                return this.itemResults; 
            } 
            set 
            {
                this.itemResults = value;
                onPropertyChanged("ItemResults");
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
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("_embedded")]
        public EmbededListModel MEmbedded 
        { 
            get 
            {
                return this.mEmbedded; 
            } 
            set 
            {
                this.mEmbedded = value;
                onPropertyChanged("MEmbedded");
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