using Telegram.Bot;
using System.IO;
using GirlsDetectiveCore.Tools;
using rdr = GirlsDetectiveCore.Tools.ConsoleRenderer;

try
{
    var botClient = new TelegramBotClient(File.ReadAllText("token.gdt"));
}
catch (FileNotFoundException e)
{
    rdr.TitlePara("启动错误");
    rdr.Para("未找到 token.gdt 文件，请在软件根目录创建它，并在其中写入机器人 token 。");
    return;
}
