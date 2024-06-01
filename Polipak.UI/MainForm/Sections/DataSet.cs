using System.Collections.ObjectModel;

namespace Polipak.UI.MainForm.Sections;

public class DataSet
{
    private static readonly Lazy<DataSet> dataset = new Lazy<DataSet>(new DataSet());

    public static ObservableCollection<object> Data { get; } = new ObservableCollection<object>();

    public static DataSet Instance => dataset.Value;

    private DataSet()
    { }
}