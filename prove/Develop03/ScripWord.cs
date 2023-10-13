public class ScripWord
{
    private string _word;
	private bool _hidden;
	
	public ScripWord()
    {
		_word = "";
		_hidden = false;
    }

    public ScripWord(string word)
    {
		_word = word;
		_hidden = false;
    }

    public ScripWord(string word, bool hide)
    {
		_word = "";
		_hidden = hide;
    }
	
	public string GetWord()
	{
		return _word;
	}
	public void SetWord(string word)
	{
		_word = word;
	}
	public bool GetHidden()
	{
		return _hidden;
	}
	public void SetHidden(bool hidden)
	{
		_hidden = hidden;
	}
	
	public string GetHiddenWord()
	{
		if(_hidden){
			string output = "";
			for (int i = 0; i < _word.Length; i++) 
			{
				output = (output + "_");
			}
			return output + " ";
		}
		else{
			return _word + " ";
		}
	}

	
}