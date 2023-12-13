public class DoetOnderzoek
{
    public int ID {get; private set;}
    public Onderzoek Onderzoek{get;}
    public Ervaringsdeskundige Ervaringsdeskundige {get; set;}
    public string? Resultaat{get; set;}
    public string? InformatieTrackingScript{get; set;}
    public Boolean Voltooid{get; set;}

    public DoetOnderzoek(Onderzoek onderzoek, Ervaringsdeskundige ervaringsdeskundige){
        this.Onderzoek = onderzoek;
        this.Ervaringsdeskundige = ervaringsdeskundige;
        Voltooid = false;
    }

    public void setResultaat(string resultaat){
        this.Resultaat = resultaat;
    }
    public void setVoltooid(Boolean voltooid){
        this.Voltooid = voltooid;
    }
    public void setInformatieTrackingScript(String infromatie){
        this.InformatieTrackingScript = infromatie;
    }
}