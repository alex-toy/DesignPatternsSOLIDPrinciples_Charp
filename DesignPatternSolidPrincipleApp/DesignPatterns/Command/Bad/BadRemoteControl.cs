using DesignPatterns.Command.Bad;

namespace DesignPatterns.Commands.Bad;

public class BadRemoteControl
{
    private BadLight _light;

    public BadRemoteControl(BadLight light)
    {
        _light = light;
    }

    public void PressButton(LightState state)
    {
        if (state == LightState.On)
        {
            _light.TurnOn();
        }
        else if (state == LightState.Off)
        {
            _light.TurnOff();
        }
        else if (state == LightState.Bright)
        {
            _light.Bright();
        }
        else
        {
            _light.Dim();
        }
    }
}
