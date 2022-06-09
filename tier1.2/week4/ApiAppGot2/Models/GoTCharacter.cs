namespace ApiAppGot2.Models
{
    public class GoTCharacter
    {
        private int _id;
        private string? _name;
        private string? _description;
        private string? _allegiance;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public string Allegiance
        {
            get { return _allegiance; }
            set { _allegiance = value; }
        }
    }
}
