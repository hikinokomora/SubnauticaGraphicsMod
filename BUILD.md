# Build Instructions / Инструкции по сборке

## Prerequisites / Предварительные требования

### English
1. .NET SDK 4.7.2 or higher
2. A C# IDE (Visual Studio, Rider, or VS Code with C# extension)
3. Git (for cloning the repository)

### Русский
1. .NET SDK 4.7.2 или выше
2. C# IDE (Visual Studio, Rider или VS Code с расширением C#)
3. Git (для клонирования репозитория)

## Building the Mod / Сборка мода

### Using Command Line / Используя командную строку

#### English
```bash
# Clone the repository
git clone https://github.com/hikinokomora/SubnauticaGraphicsMod.git
cd SubnauticaGraphicsMod

# Restore NuGet packages
dotnet restore

# Build in Debug mode
dotnet build

# Build in Release mode
dotnet build -c Release
```

The compiled DLL will be located in:
- Debug: `bin/Debug/net472/SubnauticaGraphicsMod.dll`
- Release: `bin/Release/net472/SubnauticaGraphicsMod.dll`

#### Русский
```bash
# Клонировать репозиторий
git clone https://github.com/hikinokomora/SubnauticaGraphicsMod.git
cd SubnauticaGraphicsMod

# Восстановить пакеты NuGet
dotnet restore

# Собрать в режиме Debug
dotnet build

# Собрать в режиме Release
dotnet build -c Release
```

Скомпилированная DLL будет находиться в:
- Debug: `bin/Debug/net472/SubnauticaGraphicsMod.dll`
- Release: `bin/Release/net472/SubnauticaGraphicsMod.dll`

### Using Visual Studio / Используя Visual Studio

#### English
1. Open the folder in Visual Studio
2. Visual Studio will automatically restore NuGet packages
3. Select Build → Build Solution (or press Ctrl+Shift+B)
4. The DLL will be in the bin folder

#### Русский
1. Откройте папку в Visual Studio
2. Visual Studio автоматически восстановит пакеты NuGet
3. Выберите Build → Build Solution (или нажмите Ctrl+Shift+B)
4. DLL будет в папке bin

## Installation for Testing / Установка для тестирования

### English
1. Locate your Subnautica installation directory
2. Install BepInEx if not already installed
3. Copy the compiled DLL to `Subnautica/BepInEx/plugins/`
4. Run the game to test

### Русский
1. Найдите директорию установки Subnautica
2. Установите BepInEx, если еще не установлен
3. Скопируйте скомпилированную DLL в `Subnautica/BepInEx/plugins/`
4. Запустите игру для тестирования

## Common Build Issues / Распространенные проблемы сборки

### English
- **Missing BepInEx references**: Run `dotnet restore` to download dependencies
- **Wrong .NET version**: Ensure you have .NET Framework 4.7.2 SDK installed
- **Unity references not found**: The build will download UnityEngine packages automatically

### Русский
- **Отсутствуют ссылки на BepInEx**: Выполните `dotnet restore` для загрузки зависимостей
- **Неправильная версия .NET**: Убедитесь, что у вас установлен .NET Framework 4.7.2 SDK
- **Ссылки на Unity не найдены**: Сборка автоматически загрузит пакеты UnityEngine

## Development Tips / Советы по разработке

### English
- Use Debug build for development with more detailed logging
- Use Release build for distribution (smaller, optimized)
- Check BepInEx console logs for debugging
- Modify the configuration values in Plugin.cs to change defaults

### Русский
- Используйте сборку Debug для разработки с более подробным логированием
- Используйте сборку Release для распространения (меньше, оптимизировано)
- Проверяйте логи консоли BepInEx для отладки
- Измените значения конфигурации в Plugin.cs для изменения значений по умолчанию
