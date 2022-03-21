using System;

static class LogLine
{
    public static string Message(string logLine)
    {
        //remove os espaços extras
        //e retorna reformatado
        return logLine.Substring(logLine.IndexOf(" ")).Trim();
    }

    public static string LogLevel(string logLine)
    {
        //retorna em lower case o que está entre []
        return logLine.Substring(logLine.IndexOf("[")+1, logLine.IndexOf("]") - 1).ToLower();
    }

    public static string Reformat(string logLine)
    {
        //declarando variáveis
        string fimFrase = logLine.Substring(logLine.IndexOf(" ")).Trim();
        string inicioFrase = logLine.Substring(logLine.IndexOf("[")+1, logLine.IndexOf("]")-1).ToLower();
        //retornando a frase reformatada 
        //com o aviso entre [] no final
        return $"{fimFrase} ({inicioFrase})";
    }
}
