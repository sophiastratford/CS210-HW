public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;


public Entry() {}
    public Entry(string _date, string _promptText, string _entryText) {
        this._date = _date;
        this._promptText = _promptText;
        this._entryText = _entryText;
    }

    public string GetEntryDisplay()
    {
        return _date + " " + _promptText + " " + _entryText;
    }
}