using Godot;
using MASTMAN.Util;
using System.Threading.Tasks;
using HttpClient = System.Net.Http.HttpClient;
using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using MASTMAN.Scripts.Data.Models;
using MASTMAN.Data;

public partial class Data_Manager : Node
{
    BaseDataObject _baseData;
	public override void _Ready()
	{
        if (ResourceLoader.Exists(Constants.BASE_DATA_PATH))
        {
            _baseData = (BaseDataObject)ResourceLoader.Load(Constants.BASE_DATA_PATH);
        }
        else
        {
            _baseData = new BaseDataObject(true);
            ResourceSaver.Save(_baseData, Constants.BASE_DATA_PATH);
        }


    }


}
