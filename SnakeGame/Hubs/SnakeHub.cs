using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

public class SnakeHub : Hub
{
    // 當客戶端發送位置更新時，將位置廣播給其他連接的客戶端
    public async Task UpdatePosition(string playerName, int x, int y)
    {
        // 將位置廣播給所有連接的客戶端
        await Clients.Others.SendAsync("ReceivePosition", playerName, x, y);
    }

    // 這裡可以添加更多方法，如處理遊戲結束或食物更新等邏輯
}
