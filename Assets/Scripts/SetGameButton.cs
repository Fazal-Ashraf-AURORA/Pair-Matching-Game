using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetGameButton : MonoBehaviour
{
    public enum EButtonType
    {
        NotSet,
        PairNumberBtn,
        PuzzleCategoryBtn,
    };

    [SerializeField] public EButtonType ButtonType = EButtonType.NotSet;
    [HideInInspector] public GameSettings.EPairNumber PairNumber = GameSettings.EPairNumber.NotSet;
    [HideInInspector] public GameSettings.EPuzzlecategories PuzzleCategories = GameSettings.EPuzzlecategories.NotSet;

    private void Start()
    {
        
    }

    public void SetGameOption(string GameSceneName)
    {
        SetGameButton Component = GetComponent<SetGameButton>();

        switch (Component.ButtonType)
        {
            case SetGameButton.EButtonType.PairNumberBtn:
                GameSettings.Instance.SetPairNumber(Component.PairNumber);
                break;
            case EButtonType.PuzzleCategoryBtn:
                GameSettings.Instance.SetPuzzleCategory(Component.PuzzleCategories);
                break;
        }
    }
}
