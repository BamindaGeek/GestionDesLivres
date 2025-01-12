﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Globalization;
namespace GestionDesLivres.Models
{

    public partial class BookListe
    {
        [JsonProperty("numFound")]
        public long NumFound { get; set; }

        [JsonProperty("start")]
        public long Start { get; set; }

        [JsonProperty("numFoundExact")]
        public bool NumFoundExact { get; set; }

        [JsonProperty("docs")]
        public Doc[] Docs { get; set; }

        [JsonProperty("num_found")]
        public long Welcome9NumFound { get; set; }

        [JsonProperty("q")]
        public string Q { get; set; }

        [JsonProperty("offset")]
        public object Offset { get; set; }
    }

    public partial class Doc
    {
        [JsonProperty("author_alternative_name", NullValueHandling = NullValueHandling.Ignore)]
        public string[] AuthorAlternativeName { get; set; }

        [JsonProperty("author_key", NullValueHandling = NullValueHandling.Ignore)]
        public string[] AuthorKey { get; set; }

        [JsonProperty("author_name", NullValueHandling = NullValueHandling.Ignore)]
        public string[] AuthorName { get; set; }

        [JsonProperty("contributor", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Contributor { get; set; }

        [JsonProperty("cover_edition_key", NullValueHandling = NullValueHandling.Ignore)]
        public string CoverEditionKey { get; set; }

        [JsonProperty("cover_i", NullValueHandling = NullValueHandling.Ignore)]
        public long? CoverI { get; set; }

        [JsonProperty("ddc", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Ddc { get; set; }

        [JsonProperty("ebook_access", NullValueHandling = NullValueHandling.Ignore)]
        public string EbookAccess { get; set; }
        // public EbookAccess EbookAccess { get; set; }

        [JsonProperty("ebook_count_i")]
        public long EbookCountI { get; set; }

        [JsonProperty("edition_count")]
        public long EditionCount { get; set; }

        [JsonProperty("edition_key", NullValueHandling = NullValueHandling.Ignore)]
        public string[] EditionKey { get; set; }

        [JsonProperty("first_publish_year", NullValueHandling = NullValueHandling.Ignore)]
        public long? FirstPublishYear { get; set; }

        [JsonProperty("first_sentence", NullValueHandling = NullValueHandling.Ignore)]
        public string[] FirstSentence { get; set; }

        [JsonProperty("format", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Format { get; set; }

        [JsonProperty("has_fulltext")]
        public bool HasFulltext { get; set; }

        [JsonProperty("ia", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Ia { get; set; }

        [JsonProperty("ia_collection", NullValueHandling = NullValueHandling.Ignore)]
        public string[] IaCollection { get; set; }

        [JsonProperty("ia_collection_s", NullValueHandling = NullValueHandling.Ignore)]
        public string IaCollectionS { get; set; }

        [JsonProperty("isbn", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Isbn { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Language { get; set; }

        [JsonProperty("last_modified_i")]
        public long LastModifiedI { get; set; }

        [JsonProperty("lcc", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Lcc { get; set; }

        [JsonProperty("lccn", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Lccn { get; set; }

        [JsonProperty("number_of_pages_median", NullValueHandling = NullValueHandling.Ignore)]
        public long? NumberOfPagesMedian { get; set; }

        [JsonProperty("oclc", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Oclc { get; set; }

        [JsonProperty("osp_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? OspCount { get; set; }

        [JsonProperty("printdisabled_s", NullValueHandling = NullValueHandling.Ignore)]
        public string PrintdisabledS { get; set; }

        [JsonProperty("public_scan_b")]
        public bool PublicScanB { get; set; }

        [JsonProperty("publish_date", NullValueHandling = NullValueHandling.Ignore)]
        public string[] PublishDate { get; set; }

        [JsonProperty("publish_place", NullValueHandling = NullValueHandling.Ignore)]
        public string[] PublishPlace { get; set; }

        [JsonProperty("publish_year", NullValueHandling = NullValueHandling.Ignore)]
        public long[] PublishYear { get; set; }

        [JsonProperty("publisher", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Publisher { get; set; }

        [JsonProperty("seed")]
        public string[] Seed { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("title_suggest")]
        public string TitleSuggest { get; set; }

        [JsonProperty("title_sort")]
        public string TitleSort { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }
        //public TypeEnum Type { get; set; }

        [JsonProperty("id_goodreads", NullValueHandling = NullValueHandling.Ignore)]
        public string[] IdGoodreads { get; set; }

        [JsonProperty("id_librarything", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(DecodeArrayConverter))]
        public long[] IdLibrarything { get; set; }

        [JsonProperty("id_dnb", NullValueHandling = NullValueHandling.Ignore)]
        public string[] IdDnb { get; set; }

        [JsonProperty("id_amazon", NullValueHandling = NullValueHandling.Ignore)]
        public string[] IdAmazon { get; set; }

        [JsonProperty("id_depósito_legal", NullValueHandling = NullValueHandling.Ignore)]
        public string[] IdDepósitoLegal { get; set; }

        [JsonProperty("id_alibris_id", NullValueHandling = NullValueHandling.Ignore)]
        public string[] IdAlibrisId { get; set; }

        [JsonProperty("id_google", NullValueHandling = NullValueHandling.Ignore)]
        public string[] IdGoogle { get; set; }

        [JsonProperty("id_paperback_swap", NullValueHandling = NullValueHandling.Ignore)]
        public string[] IdPaperbackSwap { get; set; }

        [JsonProperty("id_wikidata", NullValueHandling = NullValueHandling.Ignore)]
        public string[] IdWikidata { get; set; }

        [JsonProperty("id_better_world_books", NullValueHandling = NullValueHandling.Ignore)]
        public string[] IdBetterWorldBooks { get; set; }

        [JsonProperty("id_overdrive", NullValueHandling = NullValueHandling.Ignore)]
        public string[] IdOverdrive { get; set; }

        [JsonProperty("id_canadian_national_library_archive", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(DecodeArrayConverter))]
        public long[] IdCanadianNationalLibraryArchive { get; set; }

        [JsonProperty("subject", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Subject { get; set; }

        [JsonProperty("place", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Place { get; set; }

        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Time { get; set; }

        [JsonProperty("person", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Person { get; set; }

        [JsonProperty("ia_loaded_id", NullValueHandling = NullValueHandling.Ignore)]
        public string[] IaLoadedId { get; set; }

        [JsonProperty("ia_box_id", NullValueHandling = NullValueHandling.Ignore)]
        public string[] IaBoxId { get; set; }

        [JsonProperty("ratings_average", NullValueHandling = NullValueHandling.Ignore)]
        public double? RatingsAverage { get; set; }

        [JsonProperty("ratings_sortable", NullValueHandling = NullValueHandling.Ignore)]
        public double? RatingsSortable { get; set; }

        [JsonProperty("ratings_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? RatingsCount { get; set; }

        [JsonProperty("ratings_count_1", NullValueHandling = NullValueHandling.Ignore)]
        public long? RatingsCount1 { get; set; }

        [JsonProperty("ratings_count_2", NullValueHandling = NullValueHandling.Ignore)]
        public long? RatingsCount2 { get; set; }

        [JsonProperty("ratings_count_3", NullValueHandling = NullValueHandling.Ignore)]
        public long? RatingsCount3 { get; set; }

        [JsonProperty("ratings_count_4", NullValueHandling = NullValueHandling.Ignore)]
        public long? RatingsCount4 { get; set; }

        [JsonProperty("ratings_count_5", NullValueHandling = NullValueHandling.Ignore)]
        public long? RatingsCount5 { get; set; }

        [JsonProperty("readinglog_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? ReadinglogCount { get; set; }

        [JsonProperty("want_to_read_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? WantToReadCount { get; set; }

        [JsonProperty("currently_reading_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? CurrentlyReadingCount { get; set; }

        [JsonProperty("already_read_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? AlreadyReadCount { get; set; }

        [JsonProperty("publisher_facet", NullValueHandling = NullValueHandling.Ignore)]
        public string[] PublisherFacet { get; set; }

        [JsonProperty("person_key", NullValueHandling = NullValueHandling.Ignore)]
        public string[] PersonKey { get; set; }

        [JsonProperty("time_facet", NullValueHandling = NullValueHandling.Ignore)]
        public string[] TimeFacet { get; set; }

        [JsonProperty("place_key", NullValueHandling = NullValueHandling.Ignore)]
        public string[] PlaceKey { get; set; }

        [JsonProperty("person_facet", NullValueHandling = NullValueHandling.Ignore)]
        public string[] PersonFacet { get; set; }

        [JsonProperty("subject_facet", NullValueHandling = NullValueHandling.Ignore)]
        public string[] SubjectFacet { get; set; }

        [JsonProperty("_version_")]
        public long Version { get; set; }

        [JsonProperty("place_facet", NullValueHandling = NullValueHandling.Ignore)]
        public string[] PlaceFacet { get; set; }

        [JsonProperty("lcc_sort", NullValueHandling = NullValueHandling.Ignore)]
        public string LccSort { get; set; }

        [JsonProperty("author_facet", NullValueHandling = NullValueHandling.Ignore)]
        public string[] AuthorFacet { get; set; }

        [JsonProperty("subject_key", NullValueHandling = NullValueHandling.Ignore)]
        public string[] SubjectKey { get; set; }

        [JsonProperty("ddc_sort", NullValueHandling = NullValueHandling.Ignore)]
        public string DdcSort { get; set; }

        [JsonProperty("time_key", NullValueHandling = NullValueHandling.Ignore)]
        public string[] TimeKey { get; set; }

        [JsonProperty("lending_edition_s", NullValueHandling = NullValueHandling.Ignore)]
        public string LendingEditionS { get; set; }

        [JsonProperty("lending_identifier_s", NullValueHandling = NullValueHandling.Ignore)]
        public string LendingIdentifierS { get; set; }

        [JsonProperty("id_amazon_co_uk_asin", NullValueHandling = NullValueHandling.Ignore)]
        public string[] IdAmazonCoUkAsin { get; set; }

        [JsonProperty("id_amazon_de_asin", NullValueHandling = NullValueHandling.Ignore)]
        public string[] IdAmazonDeAsin { get; set; }

        [JsonProperty("id_amazon_ca_asin", NullValueHandling = NullValueHandling.Ignore)]
        public string[] IdAmazonCaAsin { get; set; }

        [JsonProperty("id_amazon_it_asin", NullValueHandling = NullValueHandling.Ignore)]
        public string[] IdAmazonItAsin { get; set; }

        [JsonProperty("id_bcid", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(DecodeArrayConverter))]
        public long[] IdBcid { get; set; }

        [JsonProperty("id_nla", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(DecodeArrayConverter))]
        public long[] IdNla { get; set; }

        [JsonProperty("id_british_national_bibliography", NullValueHandling = NullValueHandling.Ignore)]
        public string[] IdBritishNationalBibliography { get; set; }

        [JsonProperty("id_scribd", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(DecodeArrayConverter))]
        public long[] IdScribd { get; set; }

        [JsonProperty("id_hathi_trust", NullValueHandling = NullValueHandling.Ignore)]
        public string[] IdHathiTrust { get; set; }

        [JsonProperty("id_british_library", NullValueHandling = NullValueHandling.Ignore)]
        public string[] IdBritishLibrary { get; set; }

        [JsonProperty("id_bibliothèque_nationale_de_france", NullValueHandling = NullValueHandling.Ignore)]
        public string[] IdBibliothèqueNationaleDeFrance { get; set; }

        [JsonProperty("id_libris", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(DecodeArrayConverter))]
        public long[] IdLibris { get; set; }

        [JsonProperty("subtitle", NullValueHandling = NullValueHandling.Ignore)]
        public string Subtitle { get; set; }
    }

    //public enum EbookAccess { Borrowable, NoEbook, Printdisabled, Unclassified };

    //public enum TypeEnum { Work };

    //public partial class Welcome9
    //{
    //    public static Welcome9 FromJson(string json) => JsonConvert.DeserializeObject<Welcome9>(json, GestionDesLivres.Models.Converter.Settings);
    //}

    //public static class Serialize
    //{
    //    public static string ToJson(this Welcome9 self) => JsonConvert.SerializeObject(self, GestionDesLivres.Models.Converter.Settings);
    //}

    //internal static class Converter
    //{
    //    public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
    //    {
    //        MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
    //        DateParseHandling = DateParseHandling.None,
    //        Converters =
    //    {
    //        EbookAccessConverter.Singleton,
    //        TypeEnumConverter.Singleton,
    //        new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
    //    },
    //    };
    //}

    //internal class EbookAccessConverter : JsonConverter
    //{
    //    public override bool CanConvert(Type t) => t == typeof(EbookAccess) || t == typeof(EbookAccess?);

    //    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    //    {
    //        if (reader.TokenType == JsonToken.Null) return null;
    //        var value = serializer.Deserialize<string>(reader);
    //        switch (value)
    //        {
    //            case "borrowable":
    //                return EbookAccess.Borrowable;
    //            case "no_ebook":
    //                return EbookAccess.NoEbook;
    //            case "printdisabled":
    //                return EbookAccess.Printdisabled;
    //            case "unclassified":
    //                return EbookAccess.Unclassified;
    //            default:
    //                return EbookAccess.NoEbook;
    //        }
    //        throw new Exception("Cannot unmarshal type EbookAccess");
    //    }

    //    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    //    {
    //        if (untypedValue == null)
    //        {
    //            serializer.Serialize(writer, null);
    //            return;
    //        }
    //        var value = (EbookAccess)untypedValue;
    //        switch (value)
    //        {
    //            case EbookAccess.Borrowable:
    //                serializer.Serialize(writer, "borrowable");
    //                return;
    //            case EbookAccess.NoEbook:
    //                serializer.Serialize(writer, "no_ebook");
    //                return;
    //            case EbookAccess.Printdisabled:
    //                serializer.Serialize(writer, "printdisabled");
    //                return;
    //            case EbookAccess.Unclassified:
    //                serializer.Serialize(writer, "unclassified");
    //                return;
    //            default:
    //                serializer.Serialize(writer, "no_ebook");
    //                return;
    //        }
    //        throw new Exception("Cannot marshal type EbookAccess");
    //    }

    //    public static readonly EbookAccessConverter Singleton = new EbookAccessConverter();
    //}

    internal class DecodeArrayConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long[]);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            reader.Read();
            var value = new List<long>();
            while (reader.TokenType != JsonToken.EndArray)
            {
                var converter = ParseStringConverter.Singleton;
                var arrayItem = (long)converter.ReadJson(reader, typeof(long), null, serializer);
                value.Add(arrayItem);
                reader.Read();
            }
            return value.ToArray();
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (long[])untypedValue;
            writer.WriteStartArray();
            foreach (var arrayItem in value)
            {
                var converter = ParseStringConverter.Singleton;
                converter.WriteJson(writer, arrayItem, serializer);
            }
            writer.WriteEndArray();
            return;
        }

        public static readonly DecodeArrayConverter Singleton = new DecodeArrayConverter();
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }

    //internal class TypeEnumConverter : JsonConverter
    //{
    //    public override bool CanConvert(Type t) => t == typeof(TypeEnum) || t == typeof(TypeEnum?);

    //    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    //    {
    //        if (reader.TokenType == JsonToken.Null) return null;
    //        var value = serializer.Deserialize<string>(reader);
    //        if (value == "work")
    //        {
    //            return TypeEnum.Work;
    //        }
    //        throw new Exception("Cannot unmarshal type TypeEnum");
    //    }

    //    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    //    {
    //        if (untypedValue == null)
    //        {
    //            serializer.Serialize(writer, null);
    //            return;
    //        }
    //        var value = (TypeEnum)untypedValue;
    //        if (value == TypeEnum.Work)
    //        {
    //            serializer.Serialize(writer, "work");
    //            return;
    //        }
    //        throw new Exception("Cannot marshal type TypeEnum");
    //    }

    //    public static readonly TypeEnumConverter Singleton = new TypeEnumConverter();
    //}
}


