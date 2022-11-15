using System;
namespace Adherent_TP3 {

    public class Adherent {

        private String nom;
        private String prenom;
        private String email;
        private DateTime dateNaissance;
       
        public Adherent(String nom, String prenom, String email, DateTime dateNaissance) {
            this.nom = nom;
            this.prenom = prenom;
            this.email = email;
            this.dateNaissance = dateNaissance;
        }
        
        public String GetNom() {
            return this.nom;
        }
        public String GetPrenom() {
            return this.prenom;
        }
        public String GetMail() {
            return this.email;
        }
        public int GetAge() {
            return DateTime.Now.Year - this.dateNaissance.Year;
        }
       
        public void SetMail( String newMail) {
            this.email = newMail;
        }

        public override string ToString()
        {
            return this.nom + "/" + this.prenom + "/" + this.email + "/" + this.GetAge() + " ans";
        }

        public DateTime GetDateNaissance()
        {
            return this.dateNaissance;
        }
    }


}
