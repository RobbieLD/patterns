
namespace Patterns.Memento
{
    public class CheckPointSave
    {
        private string[] _save;

        public CheckPointSave(string[] race)
        {
            _save = race;
        }

        public string[] Restore()
        {
            return _save;
        }
               
        
    }
}
