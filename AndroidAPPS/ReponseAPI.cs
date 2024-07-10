namespace AndroidAPPS
{
    struct AppareilVis
    {
        public int idappAppareil { get; set; }
        public string numeroAppareil { get; set; }
        public string designationAppareil { get; set; }
        public int idappStatut { get; set; }
        public string enrARCHIVE { get; set; }
        public string marqueAppareil { get; set; }
        public string modeleApparei { get; set; }
        public string numeroSerie { get; set; }
        public int statutAppareil { get; set; }
        public string nomImage { get; set; }
    }

    struct ConditionnementVis
    {
        public int idlarConditionnement {  get; set; }
        public string numConditionnement { get; set; }
        public string reference { get; set; }
        public string numExterne { get; set; }
        public string enrARCHIVE { get; set; }
        public int idlarEtatCO { get; set; }
        public int idlarArticle { get; set; }
        public string codeArticle { get; set; }
        public string designationArticle { get; set; }
        public string numCAS { get; set; }
        public string codeInterne1 { get; set; }
        public string codeInterne2 { get; set; }
        public string nomChimique { get; set; }
        public string conditionConservation { get; set; }
        public string synonyme { get; set; }
        public int idlarStatutCO { get; set; }
        public string nomImage { get; set; }

        public string image { get; set; }
    }

    public class ReponseAPI
    {
        public int CodeEtat { get; set; }
        public DateTime DateExecution { get; set; }
        public int DureeExecution { get; set; }
        public int Occurrences { get; set; }
        public dynamic Contenu { get; set; }
    }
}
