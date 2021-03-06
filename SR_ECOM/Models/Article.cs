//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SR_ECOM.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Article
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Article()
        {
            this.Commande = new HashSet<Commande>();
        }
    
        public long Art_Id { get; set; }
        public Nullable<int> Cat_Id { get; set; }
        public Nullable<int> Fourn_Id { get; set; }
        public string Art_Designation { get; set; }
        public Nullable<decimal> Art_Prix { get; set; }
        public Nullable<int> Qte_Stock { get; set; }
        public Nullable<decimal> Taut_TVA { get; set; }
        public Nullable<decimal> Taut_Remise { get; set; }
        public byte[] Art_Img { get; set; }
        public string Art_Description { get; set; }
        public Nullable<int> Marq_Id { get; set; }
    
        public virtual Fournisseur Fournisseur { get; set; }
        public virtual Marque Marque { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Commande> Commande { get; set; }
    }
}
