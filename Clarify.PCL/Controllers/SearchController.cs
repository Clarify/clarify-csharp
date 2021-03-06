/*
 * Clarify.PCL
 *
 * This file was automatically generated by APIMATIC BETA v2.0 on 10/06/2014
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unirest_net.http;
using unirest_net.request;
using Clarify.PCL;
using Clarify.PCL.Models;

namespace Clarify.PCL.Controllers
{
    public class SearchController
    {
        /// <summary>
        /// Searches the bundles and returns a list of matching bundles, along with what matched and where for each bundle.
        /// </summary>
        /// <param name="query">Required parameter: query is used to search for text in the audio and metadata. It uses a simple query language similar to Google. At its simplest, it can be a space separated list of words (ex. open voice) which will find all bundles matching all the words. To search for a phrase, put it in quotes (ex. "open source") You can exclude bundles that contain a word by putting a minus (hyphen) in front of the word (ex. -opaque) To search for one word or another, use OR (in uppercase) between the words (ex. pizza OR pasta). As an alternative to OR, you can use | (pipe character). A full query could look something like: restaurant "little italy" pizza OR pasta -mushrooms</param>
        /// <param name="queryFields">Required parameter: list of insights, metadata, and bundle fields to search with the query. Use insights.audio_words for searching audio, metadata.* for all metadata fields, bundle.* for all bundle fields, * for audio and all fields. Default is insights.audio_words and metadata.*. List is space or comma separated single string or an array of strings. If single string, up to 1024 characters.</param>
        /// <param name="filter">Required parameter: filter expression, typically programmatically generated based on input controls and data segregation rules etc. Up to 400 characters.</param>
        /// <param name="limit">Required parameter: limit results to specified number of bundles. Default is 10. Max 100.</param>
        /// <param name="embed">Required parameter: ist of link relations to embed in the result collection. Zero or more of: items, tracks, metadata. List is space or comma separated single string or an array of strings</param>
        /// <param name="iterator">Required parameter: opaque value, automatically provided in next/prev links</param>
        /// <return>Returns the SearchResponseModel response from the API call</return>
        public SearchResponseModel GetSearch(
                string query,
                string queryFields,
                string filter,
                int limit,
                string embed,
                string iterator)
        {
            //the base uri for api requests
            string baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/search");


            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(queryBuilder, new Dictionary<string, object>()
                {
                    { "query", query },
                    { "query_fields", queryFields },
                    { "filter", filter },
                    { "limit", limit },
                    { "embed", embed },
                    { "iterator", iterator }
                });

            //validate and preprocess url
            string queryUrl = APIHelper.CleanUrl(queryBuilder);

            //prepare and invoke the API call request to fetch the response
            HttpRequest request = Unirest.get(queryUrl)
                //append request with appropriate headers and parameters
                .header("User-Agent", "APIMATIC 2.0")
                .header("Accept", "application/json")
                .header("Authorization", string.Format("Bearer {0}", Configuration.OAuthAccessToken));

            //invoke request and get response
            HttpResponse<String> response = request.asString();

            //Error handling using HTTP status codes
            if (response.Code == 400)
                throw new APIException(@"Bad request", 400);

            else if ((response.Code < 200) || (response.Code > 206)) //[200,206] = HTTP OK
                throw new APIException(@"HTTP Response Not OK", response.Code);

            return APIHelper.JsonDeserialize<SearchResponseModel>(response.Body);
        }

    }
} 