var builder = WebApplication.CreateBuilder(args);

// 添加 Razor Pages 和 SignalR 服務
builder.Services.AddRazorPages();
builder.Services.AddSignalR();

var app = builder.Build();

// 配置 HTTP 請求管道
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapRazorPages();

// 設置 SignalR Hub 路由
app.MapHub<SnakeHub>("/snakeHub");

app.Run();
