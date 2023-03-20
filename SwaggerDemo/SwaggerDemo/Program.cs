using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SwaggerDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            WebClient client = new WebClient();

            string myJSON = client.DownloadString("https://petstore.swagger.io/v2/swagger.json");

            var myClass = Newtonsoft.Json.JsonConvert.DeserializeObject(myJSON);            
        }
    }
   
    public class _200
    {
        public string description { get; set; }
        public Schema schema { get; set; }
        public Headers headers { get; set; }
    }

    public class _400
    {
        public string description { get; set; }
    }

    public class _404
    {
        public string description { get; set; }
    }

    public class _405
    {
        public string description { get; set; }
    }

    public class AdditionalProperties
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class ApiKey
    {
        public string type { get; set; }
        public string name { get; set; }
        public string @in { get; set; }
    }

    public class ApiResponse
    {
        public string type { get; set; }
        public Properties properties { get; set; }
    }

    public class Category
    {
        public string type { get; set; }
        public Properties properties { get; set; }
        public Xml xml { get; set; }
    }

    public class Category2
    {
        [JsonProperty("$ref")]
        public string @ref { get; set; }
    }

    public class Code
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Complete
    {
        public string type { get; set; }
    }

    public class Contact
    {
        public string email { get; set; }
    }

    public class Default
    {
        public string description { get; set; }
    }

    public class Definitions
    {
        public ApiResponse ApiResponse { get; set; }
        public Category Category { get; set; }
        public Pet Pet { get; set; }
        public Tag Tag { get; set; }
        public Order Order { get; set; }
        public User User { get; set; }
    }

    public class Delete
    {
        public List<string> tags { get; set; }
        public string summary { get; set; }
        public string description { get; set; }
        public string operationId { get; set; }
        public List<string> produces { get; set; }
        public List<Parameter> parameters { get; set; }
        public Responses responses { get; set; }
        public List<Security> security { get; set; }
    }

    public class Email
    {
        public string type { get; set; }
    }

    public class ExternalDocs
    {
        public string description { get; set; }
        public string url { get; set; }
    }

    public class FirstName
    {
        public string type { get; set; }
    }

    public class Get
    {
        public List<string> tags { get; set; }
        public string summary { get; set; }
        public string description { get; set; }
        public string operationId { get; set; }
        public List<string> produces { get; set; }
        public List<Parameter> parameters { get; set; }
        public Responses responses { get; set; }
        public List<Security> security { get; set; }
        public bool deprecated { get; set; }
    }

    public class Headers
    {
        [JsonProperty("X-Expires-After")]
        public XExpiresAfter XExpiresAfter { get; set; }

        [JsonProperty("X-Rate-Limit")]
        public XRateLimit XRateLimit { get; set; }
    }

    public class Id
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Info
    {
        public string description { get; set; }
        public string version { get; set; }
        public string title { get; set; }
        public string termsOfService { get; set; }
        public Contact contact { get; set; }
        public License license { get; set; }
    }

    public class Items
    {
        public string type { get; set; }
        public List<string> @enum { get; set; }
        public string @default { get; set; }

        [JsonProperty("$ref")]
        public string @ref { get; set; }
        public Xml xml { get; set; }
    }

    public class LastName
    {
        public string type { get; set; }
    }

    public class License
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Message
    {
        public string type { get; set; }
    }

    public class Name
    {
        public string type { get; set; }
        public string example { get; set; }
    }

    public class Order
    {
        public string type { get; set; }
        public Properties properties { get; set; }
        public Xml xml { get; set; }
    }

    public class Parameter
    {
        public string name { get; set; }
        public string @in { get; set; }
        public string description { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
        public string format { get; set; }
        public int maximum { get; set; }
        public int minimum { get; set; }
        public Schema schema { get; set; }
        public Items items { get; set; }
        public string collectionFormat { get; set; }
    }

    public class Password
    {
        public string type { get; set; }
    }

    public class Paths
    {
        [JsonProperty("/pet/{petId}/uploadImage")]
        public PetPetIdUploadImage petpetIduploadImage { get; set; }

        [JsonProperty("/pet")]
        public Pet pet { get; set; }

        [JsonProperty("/pet/findByStatus")]
        public PetFindByStatus petfindByStatus { get; set; }

        [JsonProperty("/pet/findByTags")]
        public PetFindByTags petfindByTags { get; set; }

        [JsonProperty("/pet/{petId}")]
        public PetPetId petpetId { get; set; }

        [JsonProperty("/store/order")]
        public StoreOrder storeorder { get; set; }

        [JsonProperty("/store/order/{orderId}")]
        public StoreOrderOrderId storeorderorderId { get; set; }

        [JsonProperty("/store/inventory")]
        public StoreInventory storeinventory { get; set; }

        [JsonProperty("/user/createWithArray")]
        public UserCreateWithArray usercreateWithArray { get; set; }

        [JsonProperty("/user/createWithList")]
        public UserCreateWithList usercreateWithList { get; set; }

        [JsonProperty("/user/{username}")]
        public UserUsername userusername { get; set; }

        [JsonProperty("/user/login")]
        public UserLogin userlogin { get; set; }

        [JsonProperty("/user/logout")]
        public UserLogout userlogout { get; set; }

        [JsonProperty("/user")]
        public User user { get; set; }
    }

    public class Pet
    {
        public Post post { get; set; }
        public Put put { get; set; }
    }

    public class Pet2
    {
        public string type { get; set; }
        public List<string> required { get; set; }
        public Properties properties { get; set; }
        public Xml xml { get; set; }
    }

    public class PetFindByStatus
    {
        public Get get { get; set; }
    }

    public class PetFindByTags
    {
        public Get get { get; set; }
    }

    public class PetId
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class PetPetId
    {
        public Get get { get; set; }
        public Post post { get; set; }
        public Delete delete { get; set; }
    }

    public class PetPetIdUploadImage
    {
        public Post post { get; set; }
    }

    public class PetstoreAuth
    {
        public string type { get; set; }
        public string authorizationUrl { get; set; }
        public string flow { get; set; }
        public Scopes scopes { get; set; }
    }

    public class Phone
    {
        public string type { get; set; }
    }

    public class PhotoUrls
    {
        public string type { get; set; }
        public Xml xml { get; set; }
        public Items items { get; set; }
    }

    public class Post
    {
        public List<string> tags { get; set; }
        public string summary { get; set; }
        public string description { get; set; }
        public string operationId { get; set; }
        public List<string> consumes { get; set; }
        public List<string> produces { get; set; }
        public List<Parameter> parameters { get; set; }
        public Responses responses { get; set; }
        public List<Security> security { get; set; }
    }

    public class Properties
    {
        public Code code { get; set; }
        public Type type { get; set; }
        public Message message { get; set; }
        public Id id { get; set; }
        public Name name { get; set; }
        public Category category { get; set; }
        public PhotoUrls photoUrls { get; set; }
        public Tags tags { get; set; }
        public Status status { get; set; }
        public PetId petId { get; set; }
        public Quantity quantity { get; set; }
        public ShipDate shipDate { get; set; }
        public Complete complete { get; set; }
        public Username username { get; set; }
        public FirstName firstName { get; set; }
        public LastName lastName { get; set; }
        public Email email { get; set; }
        public Password password { get; set; }
        public Phone phone { get; set; }
        public UserStatus userStatus { get; set; }
    }

    public class Put
    {
        public List<string> tags { get; set; }
        public string summary { get; set; }
        public string description { get; set; }
        public string operationId { get; set; }
        public List<string> consumes { get; set; }
        public List<string> produces { get; set; }
        public List<Parameter> parameters { get; set; }
        public Responses responses { get; set; }
        public List<Security> security { get; set; }
    }

    public class Quantity
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Responses
    {
        [JsonProperty("200")]
        public _200 _200 { get; set; }

        [JsonProperty("400")]
        public _400 _400 { get; set; }

        [JsonProperty("404")]
        public _404 _404 { get; set; }
        public Default @default { get; set; }

        [JsonProperty("405")]
        public _405 _405 { get; set; }
    }

    public class Root
    {
        public string swagger { get; set; }
        public Info info { get; set; }
        public string host { get; set; }
        public string basePath { get; set; }
        public List<Tag> tags { get; set; }
        public List<string> schemes { get; set; }
        public Paths paths { get; set; }
        public SecurityDefinitions securityDefinitions { get; set; }
        public Definitions definitions { get; set; }
        public ExternalDocs externalDocs { get; set; }
    }

    public class Schema
    {
        [JsonProperty("$ref")]
        public string @ref { get; set; }
        public string type { get; set; }
        public AdditionalProperties additionalProperties { get; set; }
        public Items items { get; set; }
    }

    public class Scopes
    {
        [JsonProperty("read:pets")]
        public string readpets { get; set; }

        [JsonProperty("write:pets")]
        public string writepets { get; set; }
    }

    public class Security
    {
        public List<string> petstore_auth { get; set; }
        public List<object> api_key { get; set; }
    }

    public class SecurityDefinitions
    {
        public ApiKey api_key { get; set; }
        public PetstoreAuth petstore_auth { get; set; }
    }

    public class ShipDate
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Status
    {
        public string type { get; set; }
        public string description { get; set; }
        public List<string> @enum { get; set; }
    }

    public class StoreInventory
    {
        public Get get { get; set; }
    }

    public class StoreOrder
    {
        public Post post { get; set; }
    }

    public class StoreOrderOrderId
    {
        public Get get { get; set; }
        public Delete delete { get; set; }
    }

    public class Tag
    {
        public string name { get; set; }
        public string description { get; set; }
        public ExternalDocs externalDocs { get; set; }
        public string type { get; set; }
        public Xml xml { get; set; }
        public Items items { get; set; }
    }

    public class Tags
    {
        public string type { get; set; }
        public Properties properties { get; set; }
        public Xml xml { get; set; }
    }

    public class Type
    {
        public string type { get; set; }
    }

    public class User
    {
        public Post post { get; set; }
    }

    public class User2
    {
        public string type { get; set; }
        public Properties properties { get; set; }
        public Xml xml { get; set; }
    }

    public class UserCreateWithArray
    {
        public Post post { get; set; }
    }

    public class UserCreateWithList
    {
        public Post post { get; set; }
    }

    public class UserLogin
    {
        public Get get { get; set; }
    }

    public class UserLogout
    {
        public Get get { get; set; }
    }

    public class Username
    {
        public string type { get; set; }
    }

    public class UserStatus
    {
        public string type { get; set; }
        public string format { get; set; }
        public string description { get; set; }
    }

    public class UserUsername
    {
        public Get get { get; set; }
        public Put put { get; set; }
        public Delete delete { get; set; }
    }

    public class XExpiresAfter
    {
        public string type { get; set; }
        public string format { get; set; }
        public string description { get; set; }
    }

    public class Xml
    {
        public string name { get; set; }
        public bool wrapped { get; set; }
    }

    public class XRateLimit
    {
        public string type { get; set; }
        public string format { get; set; }
        public string description { get; set; }
    }


}


