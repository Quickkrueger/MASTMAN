using Godot;
using MASTMAN.Util;
using MASTMAN.Data;
using System.Threading.Tasks;

public partial class Data_Manager : Node
{
    public BaseDataObject _baseData;
	public override void _Ready()
	{

        Task.Run(async () => await LoadBaseData());
    }

    private async Task LoadBaseData()
    {
        
            GD.Print("Loading online data");
            _baseData = new BaseDataObject(true);
            await _baseData.GetCoreJsonDataAsync();
            Error err = ResourceSaver.Save(_baseData, Constants.BASE_DATA_PATH);
            GD.Print($"Save to {Constants.BASE_DATA_PATH} returned: {err}");

        if (err != Error.Ok && ResourceLoader.Exists(Constants.BASE_DATA_PATH, "BaseDataObject"))
        {
            GD.Print("Loading existing file");
            _baseData = (BaseDataObject)ResourceLoader.Load(Constants.BASE_DATA_PATH, "BaseDataObject");
        }
        else if(err != Error.Ok)
        {
            GD.Print("No Data Available - Establish Network Connection");
        }
    }


}
