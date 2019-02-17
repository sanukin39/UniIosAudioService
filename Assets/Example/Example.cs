using UnityEngine;
using UnityEngine.UI;

public class Example : MonoBehaviour
{
    [SerializeField] private Transform _buttonParent = null;
    [SerializeField] private GameObject _buttonPrefab = null;
    [SerializeField] private TextAsset _buttonSettings = null;
    
    void Start()
    {
        InitializePlaySystemSoundButtons();
    }

    void InitializePlaySystemSoundButtons()
    {
        var lines = _buttonSettings.text.Split('\n');
        foreach (var line in lines)
        {
            if (string.IsNullOrEmpty(line))
            {
                continue;
            }
            var buttonData = line.Split(' ');
            var text = buttonData[0];
            var id = int.Parse(buttonData[1]);
            CreateButton(text, id);
        }
        _buttonPrefab.SetActive(false);
    }

    void CreateButton(string text, int index)
    {
        var button = Instantiate(_buttonPrefab);
        button.transform.SetParent(_buttonParent);
        button.GetComponent<Button>().onClick.AddListener(() => {UniIosAudioService.PlaySystemSound(index);});
        button.GetComponentInChildren<Text>().text = $"{text} : {index}";
    }
}
