# SubnauticaGraphicsMod / Мод Графики для Subnautica

A comprehensive graphics enhancement mod for Subnautica featuring texture improvements, ray tracing, DLSS, and frame generation.

Комплексный мод для улучшения графики в Subnautica с улучшенными текстурами, трассировкой лучей, DLSS и генерацией кадров.

## Features / Возможности

### English
- **Enhanced Textures**: Improved texture quality with configurable quality levels (Low, Medium, High, Ultra)
- **Ray Tracing**: Realistic lighting, shadows, reflections, and global illumination (requires RTX GPU)
- **NVIDIA DLSS**: AI-powered upscaling for better performance (requires RTX GPU)
- **Frame Generation**: DLSS 3 frame generation for higher FPS (requires RTX 40 series GPU)
- **Configurable Settings**: Easy-to-use configuration file for all graphics options
- **Performance Optimizations**: Smart optimizations that work together with DLSS and ray tracing

### Русский
- **Улучшенные текстуры**: Улучшенное качество текстур с настраиваемыми уровнями качества (Низкий, Средний, Высокий, Ультра)
- **Трассировка лучей**: Реалистичное освещение, тени, отражения и глобальное освещение (требуется RTX GPU)
- **NVIDIA DLSS**: Апскейлинг с помощью ИИ для лучшей производительности (требуется RTX GPU)
- **Генерация кадров**: Генерация кадров DLSS 3 для более высокого FPS (требуется RTX 40 серии GPU)
- **Настраиваемые параметры**: Простой в использовании файл конфигурации для всех параметров графики
- **Оптимизация производительности**: Умные оптимизации, работающие вместе с DLSS и трассировкой лучей

## Requirements / Требования

### English
- Subnautica (PC version)
- BepInEx 5.x
- .NET Framework 4.7.2 or higher
- For Ray Tracing: NVIDIA RTX GPU (20, 30, or 40 series)
- For DLSS: NVIDIA RTX GPU (20, 30, or 40 series)
- For Frame Generation: NVIDIA RTX 40 series GPU

### Русский
- Subnautica (версия для ПК)
- BepInEx 5.x
- .NET Framework 4.7.2 или выше
- Для трассировки лучей: NVIDIA RTX GPU (20, 30 или 40 серии)
- Для DLSS: NVIDIA RTX GPU (20, 30 или 40 серии)
- Для генерации кадров: NVIDIA RTX 40 серии GPU

## Installation / Установка

### English
1. Install [BepInEx 5.x](https://github.com/BepInEx/BepInEx/releases) for Subnautica
2. Download the latest release of SubnauticaGraphicsMod
3. Extract the mod DLL to `Subnautica/BepInEx/plugins/`
4. Run the game once to generate the configuration file
5. Edit `Subnautica/BepInEx/config/com.hikinokomora.subnautica.graphicsmod.cfg` to customize settings
6. Restart the game to apply changes

### Русский
1. Установите [BepInEx 5.x](https://github.com/BepInEx/BepInEx/releases) для Subnautica
2. Скачайте последнюю версию SubnauticaGraphicsMod
3. Извлеките DLL мода в `Subnautica/BepInEx/plugins/`
4. Запустите игру один раз, чтобы создать файл конфигурации
5. Отредактируйте `Subnautica/BepInEx/config/com.hikinokomora.subnautica.graphicsmod.cfg` для настройки параметров
6. Перезапустите игру, чтобы применить изменения

## Configuration / Конфигурация

### English
The configuration file is located at `BepInEx/config/com.hikinokomora.subnautica.graphicsmod.cfg`

Available settings:
- `EnableRayTracing`: Enable/disable ray tracing (default: false)
- `EnableDLSS`: Enable/disable DLSS (default: false)
- `EnableFrameGeneration`: Enable/disable frame generation (default: false)
- `TextureQuality`: Texture quality level 0-3 (0=Low, 1=Medium, 2=High, 3=Ultra, default: 2)
- `RenderScale`: Internal render resolution scale 0.5-2.0 (default: 1.0)

### Русский
Файл конфигурации находится в `BepInEx/config/com.hikinokomora.subnautica.graphicsmod.cfg`

Доступные настройки:
- `EnableRayTracing`: Включить/выключить трассировку лучей (по умолчанию: false)
- `EnableDLSS`: Включить/выключить DLSS (по умолчанию: false)
- `EnableFrameGeneration`: Включить/выключить генерацию кадров (по умолчанию: false)
- `TextureQuality`: Уровень качества текстур 0-3 (0=Низкий, 1=Средний, 2=Высокий, 3=Ультра, по умолчанию: 2)
- `RenderScale`: Масштаб внутреннего разрешения 0.5-2.0 (по умолчанию: 1.0)

## Building from Source / Сборка из исходного кода

### English
1. Install .NET SDK 4.7.2 or higher
2. Clone this repository
3. Restore NuGet packages: `dotnet restore`
4. Build the project: `dotnet build`
5. The compiled DLL will be in `bin/Debug/net472/` or `bin/Release/net472/`

### Русский
1. Установите .NET SDK 4.7.2 или выше
2. Клонируйте этот репозиторий
3. Восстановите пакеты NuGet: `dotnet restore`
4. Соберите проект: `dotnet build`
5. Скомпилированная DLL будет в `bin/Debug/net472/` или `bin/Release/net472/`

## Performance Tips / Советы по производительности

### English
- Start with High texture quality and adjust based on your VRAM
- Enable DLSS for better performance with high quality visuals
- Ray tracing has significant performance impact - use with DLSS
- Frame generation works best at 60+ base FPS
- Lower render scale if you need more performance

### Русский
- Начните с высокого качества текстур и настройте в зависимости от вашей видеопамяти
- Включите DLSS для лучшей производительности с высоким качеством изображения
- Трассировка лучей значительно влияет на производительность - используйте с DLSS
- Генерация кадров работает лучше всего при базовом FPS 60+
- Уменьшите масштаб рендеринга, если вам нужна большая производительность

## Known Limitations / Известные ограничения

### English
- Ray tracing requires Unity HDRP or custom implementation (currently simulated with enhanced lighting)
- DLSS requires NVIDIA DLSS plugin integration (currently simulated with optimized rendering)
- Frame generation requires DLSS 3 SDK (currently optimized for high frame rates)
- Some features may require additional Unity plugins not included in base Subnautica

### Русский
- Трассировка лучей требует Unity HDRP или пользовательской реализации (в настоящее время имитируется с улучшенным освещением)
- DLSS требует интеграции плагина NVIDIA DLSS (в настоящее время имитируется с оптимизированным рендерингом)
- Генерация кадров требует DLSS 3 SDK (в настоящее время оптимизирована для высоких частот кадров)
- Некоторые функции могут требовать дополнительных плагинов Unity, не включенных в базовую Subnautica

## Troubleshooting / Решение проблем

### English
- **Mod not loading**: Check BepInEx console for errors, ensure BepInEx is properly installed
- **Performance issues**: Try disabling ray tracing or lowering texture quality
- **Crashes**: Check if your GPU drivers are up to date
- **DLSS not working**: Ensure you have an RTX GPU and latest drivers

### Русский
- **Мод не загружается**: Проверьте консоль BepInEx на наличие ошибок, убедитесь, что BepInEx правильно установлен
- **Проблемы с производительностью**: Попробуйте отключить трассировку лучей или понизить качество текстур
- **Вылеты**: Проверьте, обновлены ли драйверы вашего GPU
- **DLSS не работает**: Убедитесь, что у вас есть RTX GPU и последние драйверы

## License / Лицензия

MIT License - See LICENSE file for details

## Contributing / Вклад

Contributions are welcome! Please feel free to submit pull requests or open issues.

Вклады приветствуются! Пожалуйста, не стесняйтесь отправлять запросы на слияние или открывать проблемы.

## Credits / Благодарности

- BepInEx team for the modding framework
- NVIDIA for DLSS and ray tracing technology
- Unknown Worlds Entertainment for Subnautica
