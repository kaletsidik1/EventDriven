using System;

public class Alarm{
    // 1. delegate 
    public delegate void AlarmEventHandler();

    // 2. declare an event based on that delegate
    public event AlarmEventHandler AlarmTriggered;

    // 3. method to trigger the event
    public void TriggerAlarm(){
        Console.WriteLine("Alarm is about to ring-----");

        // Trigger(Invoke) the event if there are subscribbers
        AlarmTriggered?.Invoke();
    }
}

class Program {
    public static void Main(){
        Alarm alarm = new Alarm();

        // 4. subscribe to the event 
        alarm.AlarmTriggered += onAlarmTriggered;

        // 5. simulate triggering 
        alarm.TriggerAlarm();
    }

    // the method that responds to the envent/ reaction
    static void onAlarmTriggered(){
        Console.WriteLine("Alert! Something happened!");
    }
}