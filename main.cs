
class Website
{
    private string request;
    private string answer;
    
    public void ReturnHTML();
}


class FilterListe
{
    protected string list;
    
    public void ReturnRules();
}

// Class representing the ad blocker system
class AdBlocker
{
    private string rules;
    private int counter;
    private string request;
    
    public void LoadRules();
    public void MatchURL();
    public void BlockResource();
    public void AllowResource();
    
    
    private FilterListe filterListe;
}


class Browser
{
    private string request;
    private string answer;
    
    public void RequestPage();
    public void ShowPageNoAds();
    public void CheckResource();
    
    
    private Website website;
    private AdBlocker adBlocker;
}
