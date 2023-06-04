using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Experimental.U2D.Animation;

public class LobbyManager : MonoBehaviour
{
    [SerializeField] private TMP_InputField _nameInputField;
    [SerializeField] private PlayerInfo _playerInfo;
    [SerializeField] private SpriteLibrary _spriteLibrary; 
    [SerializeField] private List<SpriteLibraryAsset> _spriteLibraries = new List<SpriteLibraryAsset>();
    private int _spriteIdx = 0;

    public void OnClickNameButton()
    {
        if(_nameInputField.text!=null)
            _playerInfo.PlayerName = _nameInputField.text;
        _playerInfo.CharacterIdx = _spriteIdx;
    }

    public void OnClickNextButton()
    {
        ++_spriteIdx;
        if (_spriteIdx > _spriteLibraries.Count - 1)
        {
            _spriteIdx = 0;
        }

        _spriteLibrary.spriteLibraryAsset = _spriteLibraries[_spriteIdx];
    }

    public void OnClickPreButton()
    {
        --_spriteIdx;
        if (_spriteIdx < 0)
        {
            _spriteIdx = _spriteLibraries.Count - 1;
        }
        _spriteLibrary.spriteLibraryAsset = _spriteLibraries[_spriteIdx];
    }
}
