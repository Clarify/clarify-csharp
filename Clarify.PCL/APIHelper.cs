/*
 * Clarify.PCL
 *
 * This file was automatically generated by APIMATIC BETA v2.0 on 10/06/2014
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using unirest_net.request;

namespace Clarify.PCL {
	static class APIHelper {
		/// <summary>JSON Serialization of a given object.</summary>
		/// <param name="obj">The object to serialize into JSON</param>
		/// <returns>The serialized Json string representation of the given object</returns>
		internal static string JsonSerialize( object obj ) {
			if( null == obj ) return null;

			return JsonConvert.SerializeObject( obj, Formatting.None, new JsonSerializerSettings() {
				Converters = new List<JsonConverter> {
					new Newtonsoft.Json.Converters.StringEnumConverter()
                }
			} );
		}

		/// <summary>JSON Deserialization of the given json string.</summary>
		/// <param name="json">The json string to deserialize</param>
		/// <typeparam name="T">The type of the object to desialize into</typeparam>
		/// <returns>The deserialized object</returns>
		internal static T JsonDeserialize<T>( string json ) {
			if( string.IsNullOrWhiteSpace( json ) )
				return default( T );

			return JsonConvert.DeserializeObject<T>( json );
		}

		/// <summary>Replaces template parameters in the given url</summary>
		/// <param name="queryUrl">The query url string to replace the template parameters</param>
		/// <param name="parameters">The parameters to replace in the url</param>        
		internal static void AppendUrlWithTemplateParameters
			( StringBuilder queryBuilder, IEnumerable<KeyValuePair<string, object>> parameters ) {
			//perform parameter validation
			if( null == queryBuilder )
				throw new ArgumentNullException( "queryBuilder" );

			if( null == parameters )
				return;

			//iterate and replace parameters
			foreach( KeyValuePair<string, object> pair in parameters ) {
				string replaceValue = string.Empty;

				//load paramter value
				if( null != pair.Value )
					replaceValue = pair.Value.ToString();

				//find the template parameter and replace it with its value
				queryBuilder.Replace( string.Format( "{{{0}}}", pair.Key ), replaceValue );
			}
		}

		/// <summary>
		/// Appends the given set of parameters to the given query string
		/// </summary>
		/// <param name="queryUrl">The query url string to append the parameters</param>
		/// <param name="parameters">The parameters to append</param>        
		internal static void AppendUrlWithQueryParameters
			( StringBuilder queryBuilder, IEnumerable<KeyValuePair<string, object>> parameters ) {
			//perform parameter validation
			if( null == queryBuilder )
				throw new ArgumentNullException( "queryBuilder" );

			if( null == parameters )
				return;

			//does the query string already has parameters
			bool hasParams = queryBuilder.ToString().IndexOf( "?" ) > 0 ;

			//iterate and append parameters
			foreach( KeyValuePair<string, object> pair in parameters ) {
				//ignore null values
				if( pair.Value == null )
					continue;

				//if already has parameters, use the &amp; to append new parameters
				char separator = ( hasParams ) ? '&' : '?';

				queryBuilder.AppendFormat( "{0}{1}={2}", separator, pair.Key, pair.Value );

				//indicate that now the query has some params
				hasParams = true;
			}
		}

		/// <summary>Validates and processes the given query Url to clean empty slashes</summary>
		/// <param name="queryBuilder">The given query Url to process</param>
		/// <returns>Clean Url as string</returns>
		internal static string CleanUrl( StringBuilder queryBuilder ) {
			//convert to immutable string
			string url = queryBuilder.ToString();

			//ensure that the urls are absolute            
			Match protocol = Regex.Match( url, "^https?://[^/]+" );
			if( !protocol.Success )
				throw new ArgumentException( "Invalid Url format." );

			//remove redundant forward slashes
			string query = url.Substring( protocol.Length );
			query = Regex.Replace( query, "//+", "/" );

			//return process url
			return string.Concat( protocol.Value, query );
		}
	}
}
