/* 
 * SendinBlue API
 *
 * SendinBlue provide a RESTFul API that can be used with any languages. With this API, you will be able to :   - Manage your campaigns and get the statistics   - Manage your contacts   - Send transactional Emails and SMS   - and much more...  You can download our wrappers at https://github.com/orgs/sendinblue  **Possible responses**   | Code | Message |   | :- -- -- -- -- -- --: | - -- -- -- -- -- -- |   | 200  | OK. Successful Request  |   | 201  | OK. Successful Creation |   | 202  | OK. Request accepted |   | 204  | OK. Successful Update/Deletion  |   | 400  | Error. Bad Request  |   | 401  | Error. Authentication Needed  |   | 402  | Error. Not enough credit, plan upgrade needed  |   | 403  | Error. Permission denied  |   | 404  | Error. Object does not exist |   | 405  | Error. Method not allowed  |   | 406  | Error. Not Acceptable  | 
 *
 * OpenAPI spec version: 3.0.0
 * Contact: contact@sendinblue.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = sib_api_v3_sdk.Client.SwaggerDateConverter;

namespace sib_api_v3_sdk.Model
{
    /// <summary>
    /// GetTransacEmailContentEvents
    /// </summary>
    [DataContract]
    public partial class GetTransacEmailContentEvents :  IEquatable<GetTransacEmailContentEvents>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransacEmailContentEvents" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetTransacEmailContentEvents() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransacEmailContentEvents" /> class.
        /// </summary>
        /// <param name="name">Name of the event that occurred on the sent email (required).</param>
        /// <param name="time">Time at which the event occurred (required).</param>
        public GetTransacEmailContentEvents(string name = default(string), string time = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for GetTransacEmailContentEvents and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "time" is required (not null)
            if (time == null)
            {
                throw new InvalidDataException("time is a required property for GetTransacEmailContentEvents and cannot be null");
            }
            else
            {
                this.Time = time;
            }
        }
        
        /// <summary>
        /// Name of the event that occurred on the sent email
        /// </summary>
        /// <value>Name of the event that occurred on the sent email</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Time at which the event occurred
        /// </summary>
        /// <value>Time at which the event occurred</value>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public string Time { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetTransacEmailContentEvents {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetTransacEmailContentEvents);
        }

        /// <summary>
        /// Returns true if GetTransacEmailContentEvents instances are equal
        /// </summary>
        /// <param name="input">Instance of GetTransacEmailContentEvents to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetTransacEmailContentEvents input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
                return hashCode;
            }
        }
    }

}
