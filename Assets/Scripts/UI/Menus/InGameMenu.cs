using UnityEngine;
using UnityEngine.UI;

public class InGameMenu : Menu, IAnyAirListener //IExecuteSystem
{
    public Button pauseButton;
    //public TextMeshProUGUI airText;
    [SerializeField] private Slider airSlider;

    public void OnAnyAir(GameEntity entity, float value)
    {
        
    }

    protected override void OnInitialize()
    {
        pauseButton.onClick.AddListener(OnPauseButtonClicked);
        var entity = Contexts.sharedInstance.game.CreateEntity();
        entity.AddAnyAirListener(this);

        airSlider.minValue = Time.time;
        airSlider.maxValue = Time.time + GameConfig.Instance.initialAir;
    }

    private void OnPauseButtonClicked()
    {
        Time.timeScale = 0;
        menuManager.Show<PauseMenu>();
    }

    private void Update()
    {
        airSlider.value = Time.time;
    }

    // public void Execute()
    // {
    //     airSlider.value = Time.time;
    // }
}
