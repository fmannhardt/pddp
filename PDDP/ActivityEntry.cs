using LINQtoCSV;

namespace PDDP
{
    class ActivityEntry
    {
        [CsvColumn(FieldIndex = 1)]
        public string Activity { get; set; }

        [CsvColumn(FieldIndex = 2)]
        public string Id { get; set; }

        public override string ToString()
        {
            return Activity;
        }
    }
}
