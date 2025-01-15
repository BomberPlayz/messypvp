using FishNet.Managing;
using FishNet.Object;
using FishNet.Transporting.Tugboat;
using UnityEngine;
using UnityEngine.UIElements;

public class MenuManager : MonoBehaviour
{
    private Button _joinButton;
    private Button _startButton;
    private TextField _usernameField;
    private TextField _ipAddressField;
    private Toggle _isServerToggle;
    private MultiColumnListView _playersListView;

    public static GameObject NetworkManager;

    private void OnEnable()
    {
        var uiDocument = GetComponent<UIDocument>();
        _joinButton = uiDocument.rootVisualElement.Q<Button>("JoinButton");
        _startButton = uiDocument.rootVisualElement.Q<Button>("StartButton");
        _usernameField = uiDocument.rootVisualElement.Q<TextField>("UsernameField");
        _ipAddressField = uiDocument.rootVisualElement.Q<TextField>("IpAddressField");
        _isServerToggle = uiDocument.rootVisualElement.Q<Toggle>("IsServerToggle");
        _playersListView = uiDocument.rootVisualElement.Q<MultiColumnListView>("PlayersListView");

        _joinButton.clicked += OnJoinButtonPressed;
    }

    private void OnJoinButtonPressed()
    {
        Tugboat tugboat = NetworkManager.GetComponent<Tugboat>();
        if (_isServerToggle.value)
        {
            tugboat.StartConnection(true); // Start as server
        }
        tugboat.StartConnection(false); // start as client too
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }
}
