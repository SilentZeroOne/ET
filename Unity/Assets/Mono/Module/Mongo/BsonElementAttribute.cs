using System;

namespace MongoDB.Bson.Serialization.Attributes
{
    public class BsonElementAttribute: Attribute
    {
        public BsonElementAttribute()
        {}

        public BsonElementAttribute(string s)
        {
        }
    }

    public class BsonRepresentationAttribute: Attribute
    {
        public BsonRepresentationAttribute(){}
        
        public BsonRepresentationAttribute(string s){}
    }
}