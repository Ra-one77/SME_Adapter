using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMEAdapter.Domain.Entities
{
    public class ProductDocument
    {
        public Guid Id { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public byte[] Data { get; set; }
        public DocumentVersion Version { get; set; } = new();
        public DocumentIdentifier Identifier { get; set; } = new();
        public DocumentClassification Classification { get; set; } = new();

        public Guid ProductId { get; set; }
        public Product Product { get; set; }
    }


    public class DocumentVersion
    {
        public string? Language { get; set; }
        public string? Version { get; set; }
        public string? Title { get; set; }
        public string? Summary { get; set; }
        public string? Keywords { get; set; }
        public string? State { get; set; }
        public DateTime? StateDate { get; set; }
        public string? OrganisationName { get; set; }
        public string? OrganisationOfficialName { get; set; }
    }


    public class DocumentIdentifier
    {
        public string? ValueId { get; set; }
        public string? DomainId { get; set; }
    }


    public class DocumentClassification
    {
        public string? ClassificationSystem { get; set; }
        public string? ClassName { get; set; }
        public string? ClassLang { get; set; }
        public string? ClassDescription { get; set; }
        public string? ClassId { get; set; }
    }
}
