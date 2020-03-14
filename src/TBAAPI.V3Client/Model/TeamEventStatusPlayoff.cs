/* 
 * The Blue Alliance API v3
 *
 * # Overview    Information and statistics about FIRST Robotics Competition teams and events.   # Authentication   All endpoints require an Auth Key to be passed in the header `X-TBA-Auth-Key`. If you do not have an auth key yet, you can obtain one from your [Account Page](/account).    A `User-Agent` header may need to be set to prevent a 403 Unauthorized error.
 *
 * The version of the OpenAPI document: 3.8.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = TBAAPI.V3Client.Client.OpenAPIDateConverter;

namespace TBAAPI.V3Client.Model
{
    /// <summary>
    /// Playoff status for this team, may be null if the team did not make playoffs, or playoffs have not begun.
    /// </summary>
    [DataContract]
    public partial class TeamEventStatusPlayoff :  IEquatable<TeamEventStatusPlayoff>, IValidatableObject
    {
        /// <summary>
        /// The highest playoff level the team reached.
        /// </summary>
        /// <value>The highest playoff level the team reached.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LevelEnum
        {
            /// <summary>
            /// Enum Qm for value: qm
            /// </summary>
            [EnumMember(Value = "qm")]
            Qm = 1,

            /// <summary>
            /// Enum Ef for value: ef
            /// </summary>
            [EnumMember(Value = "ef")]
            Ef = 2,

            /// <summary>
            /// Enum Qf for value: qf
            /// </summary>
            [EnumMember(Value = "qf")]
            Qf = 3,

            /// <summary>
            /// Enum Sf for value: sf
            /// </summary>
            [EnumMember(Value = "sf")]
            Sf = 4,

            /// <summary>
            /// Enum F for value: f
            /// </summary>
            [EnumMember(Value = "f")]
            F = 5

        }

        /// <summary>
        /// The highest playoff level the team reached.
        /// </summary>
        /// <value>The highest playoff level the team reached.</value>
        [DataMember(Name="level", EmitDefaultValue=false)]
        public LevelEnum? Level { get; set; }
        /// <summary>
        /// Current competition status for the playoffs.
        /// </summary>
        /// <value>Current competition status for the playoffs.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Won for value: won
            /// </summary>
            [EnumMember(Value = "won")]
            Won = 1,

            /// <summary>
            /// Enum Eliminated for value: eliminated
            /// </summary>
            [EnumMember(Value = "eliminated")]
            Eliminated = 2,

            /// <summary>
            /// Enum Playing for value: playing
            /// </summary>
            [EnumMember(Value = "playing")]
            Playing = 3

        }

        /// <summary>
        /// Current competition status for the playoffs.
        /// </summary>
        /// <value>Current competition status for the playoffs.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamEventStatusPlayoff" /> class.
        /// </summary>
        /// <param name="level">The highest playoff level the team reached..</param>
        /// <param name="currentLevelRecord">currentLevelRecord.</param>
        /// <param name="record">record.</param>
        /// <param name="status">Current competition status for the playoffs..</param>
        /// <param name="playoffAverage">The average match score during playoffs. Year specific. May be null if not relevant for a given year..</param>
        public TeamEventStatusPlayoff(LevelEnum? level = default(LevelEnum?), WLTRecord currentLevelRecord = default(WLTRecord), WLTRecord record = default(WLTRecord), StatusEnum? status = default(StatusEnum?), int playoffAverage = default(int))
        {
            this.Level = level;
            this.CurrentLevelRecord = currentLevelRecord;
            this.Record = record;
            this.Status = status;
            this.PlayoffAverage = playoffAverage;
        }
        

        /// <summary>
        /// Gets or Sets CurrentLevelRecord
        /// </summary>
        [DataMember(Name="current_level_record", EmitDefaultValue=false)]
        public WLTRecord CurrentLevelRecord { get; set; }

        /// <summary>
        /// Gets or Sets Record
        /// </summary>
        [DataMember(Name="record", EmitDefaultValue=false)]
        public WLTRecord Record { get; set; }


        /// <summary>
        /// The average match score during playoffs. Year specific. May be null if not relevant for a given year.
        /// </summary>
        /// <value>The average match score during playoffs. Year specific. May be null if not relevant for a given year.</value>
        [DataMember(Name="playoff_average", EmitDefaultValue=false)]
        public int PlayoffAverage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TeamEventStatusPlayoff {\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  CurrentLevelRecord: ").Append(CurrentLevelRecord).Append("\n");
            sb.Append("  Record: ").Append(Record).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  PlayoffAverage: ").Append(PlayoffAverage).Append("\n");
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
            return this.Equals(input as TeamEventStatusPlayoff);
        }

        /// <summary>
        /// Returns true if TeamEventStatusPlayoff instances are equal
        /// </summary>
        /// <param name="input">Instance of TeamEventStatusPlayoff to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeamEventStatusPlayoff input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Level == input.Level ||
                    (this.Level != null &&
                    this.Level.Equals(input.Level))
                ) && 
                (
                    this.CurrentLevelRecord == input.CurrentLevelRecord ||
                    (this.CurrentLevelRecord != null &&
                    this.CurrentLevelRecord.Equals(input.CurrentLevelRecord))
                ) && 
                (
                    this.Record == input.Record ||
                    (this.Record != null &&
                    this.Record.Equals(input.Record))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.PlayoffAverage == input.PlayoffAverage ||
                    (this.PlayoffAverage != null &&
                    this.PlayoffAverage.Equals(input.PlayoffAverage))
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
                if (this.Level != null)
                    hashCode = hashCode * 59 + this.Level.GetHashCode();
                if (this.CurrentLevelRecord != null)
                    hashCode = hashCode * 59 + this.CurrentLevelRecord.GetHashCode();
                if (this.Record != null)
                    hashCode = hashCode * 59 + this.Record.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.PlayoffAverage != null)
                    hashCode = hashCode * 59 + this.PlayoffAverage.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}