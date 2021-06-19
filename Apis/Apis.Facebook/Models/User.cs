using Apis.Models;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace Apis.Facebook.Models
{
    public class User : BaseModel<FacebookError>
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("about")]
        public string About { get; set; }
        [JsonPropertyName("age_range")]
        public AgeRange AgeRange { get; set; }
        [JsonPropertyName("birthday")]
        public string Birthday { get; set; }
        [JsonPropertyName("email")]
        public string Email { get; set; }
        [JsonPropertyName("favorite_athletes")]
        public List<Experience> FavoriteAthletes { get; set; }
        [JsonPropertyName("favorite_teams")]
        public List<Experience> FavoriteTeams { get; set; }
        [JsonPropertyName("first_name")]
        public string Firstname { get; set; }
        [JsonPropertyName("gender")]
        public string Gender { get; set; }
        [JsonPropertyName("hometown")]
        public Page Hometown { get; set; }
        [JsonPropertyName("inspirational_people")]
        public List<Experience> InspirationalPeople { get; set; }
        [JsonPropertyName("interested_in")]
        public List<string> InterestedIn { get; set; }
        [JsonPropertyName("is_guest_user")]
        public bool IsUserGuest { get; set; }
        [JsonPropertyName("languages")]
        public List<Experience> Languages { get; set; }
        [JsonPropertyName("last_name")]
        public string Lastname { get; set; }
        [JsonPropertyName("link")]
        public string Link { get; set; }
        [JsonPropertyName("location")]
        public Page Location { get; set; }
        [JsonPropertyName("meeting_for")]
        public List<string> MeetingFor { get; set; }
        [JsonPropertyName("middle_name")]
        public string Middlename { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("name_format")]
        public string NameFormat { get; set; }
        [JsonPropertyName("political")]
        public string Political { get; set; }
        [JsonPropertyName("profile_pic")]
        public string ProfilePic { get; set; }
        [JsonPropertyName("quotes")]
        public string Quotes { get; set; }
        [JsonPropertyName("relationship_status")]
        public string RelationshipStatus { get; set; }
        [JsonPropertyName("religion")]
        public string Religion { get; set; }
        [JsonPropertyName("shared_login_upgrade_required_by")]
        public DateTime SharedLoginUpgradeRequiredBy { get; set; }
        [JsonPropertyName("short_name")]
        public string ShortName { get; set; }
        [JsonPropertyName("sports")]
        public List<Experience> Sports { get; set; }
        [JsonPropertyName("website")]
        public string Website { get; set; }
    }
}