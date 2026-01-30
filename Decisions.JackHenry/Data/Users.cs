using System;
using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using Newtonsoft.Json;

namespace Decisions.JackHenry
{
    /// <summary>
    /// User's admin level in the Organization
    /// </summary>
    public enum AdminLevel
    {
        [EnumMember(Value = @"Admin")]
        Admin = 0,

        [EnumMember(Value = @"Viewer")]
        Viewer = 1,

        [EnumMember(Value = @"User")]
        User = 2,
    }

    /// <summary>
    /// A user's account standing within Banno
    /// </summary>
    public enum Status
    {
        [EnumMember(Value = @"Active")]
        Active = 0,

        [EnumMember(Value = @"Pending")]
        Pending = 1,

        [EnumMember(Value = @"Disabled")]
        Disabled = 2,

        [EnumMember(Value = @"Reset")]
        Reset = 3,

        [EnumMember(Value = @"Dormant")]
        Dormant = 4,

        [EnumMember(Value = @"Locked")]
        Locked = 5,

        [EnumMember(Value = @"PasswordExpired")]
        PasswordExpired = 6,
    }

    /// <summary>
    /// A name/value pair describing the name and value of a user's attribute
    /// </summary>
    [Writable, DataContract]
    public class UserAttribute
    {
        [WritableValue, DataMember]
        [JsonProperty("name")]
        public string Name { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    /// <summary>
    /// Basic object containing user information.
    /// </summary>
    [Writable, DataContract]
    public class UserInfo
    {
        /// <summary>
        /// Identifier for the user in Banno systems. This should match the userId parameter input parameter.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("userId")]
        public string UserId { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Identifier for the login in Banno systems. This differs from the userId value, as users may have multiple logins.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("loginId")]
        public string LoginId { get; set; }

        /// <summary>
        /// Member number from the institution. This does not need to be padded.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("memberNumber")]
        public string MemberNumber { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("email")]
        public string Email { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("userType")]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public UserInfoUserType UserType { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("provider")]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public UserInfoProvider Provider { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("middleName")]
        public string MiddleName { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("username")]
        public string Username { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("businessName")]
        public string BusinessName { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("preferredName")]
        public string PreferredName { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("adminLevel")]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AdminLevel AdminLevel { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("address")]
        public Address Address { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("userVerified")]
        public bool UserVerified { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("lastEulaAcceptance")]
        public LastEulaAcceptance LastEulaAcceptance { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("userAddedDateTime")]
        public DateTimeOffset UserAddedDateTime { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("institutionId")]
        public string InstitutionId { get; set; }

        /// <summary>
        /// User-specific attributes. This will either not exist, or will contain values for the attributes "NetTeller Id" and "Cash Management Id".
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("attributes")]
        public UserAttribute[] Attributes { get; set; }

        /// <summary>
        /// The method by which the user enrolled in Banno
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("enrollmentType")]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public UserInfoEnrollmentType EnrollmentType { get; set; }

        /// <summary>
        /// Identifier for the user in UIS.
        /// </summary>
        [WritableValue, DataMember]
        [JsonProperty("uisId")]
        public string UisId { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("organization")]
        public Organization Organization { get; set; }
    }

    public enum UserInfoUserType
    {
        [EnumMember(Value = @"Individual")]
        Individual = 0,

        [EnumMember(Value = @"Business")]
        Business = 1,
    }

    public enum UserInfoProvider
    {
        [EnumMember(Value = @"online_banking")]
        Online_banking = 0,

        [EnumMember(Value = @"core")]
        Core = 1,

        [EnumMember(Value = @"netteller")]
        Netteller = 2,

        [EnumMember(Value = @"symxchange")]
        Symxchange = 3,
    }

    [Writable, DataContract]
    public class Address
    {
        [WritableValue, DataMember]
        [JsonProperty("streetAddress")]
        public string StreetAddress { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("streetAddress2")]
        public string StreetAddress2 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("streetAddress3")]
        public string StreetAddress3 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("streetAddress4")]
        public string StreetAddress4 { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("city")]
        public string City { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("state")]
        public string State { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("zip")]
        public string Zip { get; set; }
    }

    [Writable, DataContract]
    public class LastEulaAcceptance
    {
        [WritableValue, DataMember]
        [JsonProperty("acceptedAt")]
        public string AcceptedAt { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("eulaId")]
        public string EulaId { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("userId")]
        public string UserId { get; set; }
    }

    public enum UserInfoEnrollmentType
    {
        [EnumMember(Value = @"seeded")]
        Seeded = 0,

        [EnumMember(Value = @"drafted")]
        Drafted = 1,

        [EnumMember(Value = @"self_enrolled")]
        Self_enrolled = 2,
    }

    [Writable, DataContract]
    public class Organization
    {
        [WritableValue, DataMember]
        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("status")]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Status Status { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("adminLevel")]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AdminLevel AdminLevel { get; set; }

        [WritableValue, DataMember]
        [JsonProperty("alias")]
        public string Alias { get; set; }
    }
}
