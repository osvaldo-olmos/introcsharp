using System.Threading;
using System.Threading.Tasks;

namespace AsynchronousProg.Models
{
public class TimeConsumingModel
{
    public string HeavyContent1()
    {
        Thread.Sleep(2000);
        return "Content 1";
    }

    public string HeavyContent2()
    {
        Thread.Sleep(5000);
        return "Content 2";
    }

    public string HeavyContent3()
    {
        Thread.Sleep(3000);
        return "Content 3";
    }
    public async Task<string> HeavyContent1Async()
    {
        await Task.Delay(2000);
        return "Content 1";
    }

    public async Task<string> HeavyContent2Async()
    {
        await Task.Delay(5000);
        return "Content 2";
    }

    public async Task<string> HeavyContent3Async()
    {
        await Task.Delay(3000);
        return "Content 3";
    }
}

}