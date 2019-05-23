namespace FolderMonitor
{
    public class FolderSpecification
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public ErrorState ErrorState { get; set; }
        public int? MaxFileAgeInDays { get; set; }
    }
}