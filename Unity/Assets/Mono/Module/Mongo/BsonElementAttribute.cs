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
        private bool _allowTruncation;
        public BsonRepresentationAttribute(){}
        
        public BsonRepresentationAttribute(BsonType a){}

        public BsonRepresentationAttribute(BsonType a, bool allowTruncation)
        {
            this._allowTruncation = allowTruncation;
        }

        public bool AllowTruncation
        {
            get => this._allowTruncation;
            set => this._allowTruncation = value;
        }
    }
    
    public enum BsonType
    {
        /// <summary>
        /// Not a real BSON type. Used to signal the end of a document.
        /// </summary>
        EndOfDocument = 0,
        /// <summary>A BSON double.</summary>
        Double = 1,
        /// <summary>A BSON string.</summary>
        String = 2,
        /// <summary>A BSON document.</summary>
        Document = 3,
        /// <summary>A BSON array.</summary>
        Array = 4,
        /// <summary>BSON binary data.</summary>
        Binary = 5,
        /// <summary>A BSON undefined value.</summary>
        Undefined = 6,
        /// <summary>A BSON ObjectId.</summary>
        ObjectId = 7,
        /// <summary>A BSON bool.</summary>
        Boolean = 8,
        /// <summary>A BSON DateTime.</summary>
        DateTime = 9,
        /// <summary>A BSON null value.</summary>
        Null = 10, // 0x0000000A
        /// <summary>A BSON regular expression.</summary>
        RegularExpression = 11, // 0x0000000B
        /// <summary>BSON JavaScript code.</summary>
        JavaScript = 13, // 0x0000000D
        /// <summary>A BSON symbol.</summary>
        Symbol = 14, // 0x0000000E
        /// <summary>
        /// BSON JavaScript code with a scope (a set of variables with values).
        /// </summary>
        JavaScriptWithScope = 15, // 0x0000000F
        /// <summary>A BSON 32-bit integer.</summary>
        Int32 = 16, // 0x00000010
        /// <summary>A BSON timestamp.</summary>
        Timestamp = 17, // 0x00000011
        /// <summary>A BSON 64-bit integer.</summary>
        Int64 = 18, // 0x00000012
        /// <summary>A BSON 128-bit decimal.</summary>
        Decimal128 = 19, // 0x00000013
        /// <summary>A BSON MaxKey value.</summary>
        MaxKey = 127, // 0x0000007F
        /// <summary>A BSON MinKey value.</summary>
        MinKey = 255, // 0x000000FF
    }
}