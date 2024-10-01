using UnityEngine;

public class GameSettings : MonoBehaviour
{
    private int _settings;
    private const int SettingsNumber = 2;

    public enum EPairNumber
    {
        NotSet = 0,
        E10Pairs = 10, 
        E15Pairs = 15,
        E20Pairs = 20,
    }

    public enum EPuzzlecategories
    {
        NotSet,
        Fruits,
        Vegetables,
    }

    public struct Settings
    {
        public EPairNumber PairsNumber;
        public EPuzzlecategories PuzzleCategory;
    };

    private Settings _gameSettings;

    public static GameSettings Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(this);
            Instance = this;
        }
        else
        {
            Destroy(this);
        }

    }

    void Start()
    {
        _gameSettings = new Settings();
        ResetGameSettings();
    }

    public void SetPairNumber(EPairNumber number)
    {
        if (_gameSettings.PairsNumber == EPairNumber.NotSet)
            _settings++;

        _gameSettings.PairsNumber = number;
    }

    public void SetPuzzleCategory(EPuzzlecategories category)
    {
        if(_gameSettings.PuzzleCategory == EPuzzlecategories.NotSet)
            _settings++;

        _gameSettings.PuzzleCategory = category;
    }

    public EPairNumber GetPairNumber()
    {
        return _gameSettings.PairsNumber;
    }

    public EPuzzlecategories GetPuzzleCategories()
    {
        return _gameSettings.PuzzleCategory;
    }

    public void ResetGameSettings()
    {
        _settings = 0;
        _gameSettings.PairsNumber = EPairNumber.NotSet;
        _gameSettings.PuzzleCategory = EPuzzlecategories.NotSet;
    }

    public bool AllSettingsReady()
    {
        return _settings == SettingsNumber;
    }
}
