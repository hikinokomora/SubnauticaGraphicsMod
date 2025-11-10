# Usage Guide / Руководство по использованию

## Quick Start / Быстрый старт

### English
1. Install BepInEx 5.x for Subnautica
2. Copy `SubnauticaGraphicsMod.dll` to `Subnautica/BepInEx/plugins/`
3. Run Subnautica once to generate config file
4. Edit config at `Subnautica/BepInEx/config/com.hikinokomora.subnautica.graphicsmod.cfg`
5. Restart Subnautica

### Русский
1. Установите BepInEx 5.x для Subnautica
2. Скопируйте `SubnauticaGraphicsMod.dll` в `Subnautica/BepInEx/plugins/`
3. Запустите Subnautica один раз для создания конфигурации
4. Отредактируйте конфигурацию в `Subnautica/BepInEx/config/com.hikinokomora.subnautica.graphicsmod.cfg`
5. Перезапустите Subnautica

## Configuration Guide / Руководство по настройке

### Texture Quality / Качество текстур

#### English
The `TextureQuality` setting controls the quality of textures:

- **0 (Low)**: Lowest quality, best performance
  - Quarter resolution textures
  - No anisotropic filtering
  - Bilinear filtering
  - Best for: Low-end GPUs, GPUs with limited VRAM (2GB or less)

- **1 (Medium)**: Balanced quality
  - Half resolution textures
  - 2x anisotropic filtering
  - Bilinear filtering
  - Best for: Mid-range GPUs (GTX 1050/1060, RX 570/580)

- **2 (High)**: High quality (default)
  - Near full resolution textures
  - 8x anisotropic filtering
  - Trilinear filtering
  - Best for: High-end GPUs (GTX 1070/1080, RTX 2060/2070, RX 5700)

- **3 (Ultra)**: Maximum quality
  - Full resolution textures
  - 16x anisotropic filtering
  - Trilinear filtering
  - Best for: Enthusiast GPUs (RTX 3070/3080/3090/4080/4090, RX 6800/6900)

#### Русский
Настройка `TextureQuality` контролирует качество текстур:

- **0 (Низкий)**: Самое низкое качество, лучшая производительность
  - Текстуры в четверть разрешения
  - Без анизотропной фильтрации
  - Билинейная фильтрация
  - Подходит для: GPU начального уровня, GPU с ограниченной видеопамятью (2 ГБ или менее)

- **1 (Средний)**: Сбалансированное качество
  - Текстуры в половину разрешения
  - 2x анизотропная фильтрация
  - Билинейная фильтрация
  - Подходит для: GPU среднего класса (GTX 1050/1060, RX 570/580)

- **2 (Высокий)**: Высокое качество (по умолчанию)
  - Почти полное разрешение текстур
  - 8x анизотропная фильтрация
  - Трилинейная фильтрация
  - Подходит для: GPU высокого класса (GTX 1070/1080, RTX 2060/2070, RX 5700)

- **3 (Ультра)**: Максимальное качество
  - Полное разрешение текстур
  - 16x анизотропная фильтрация
  - Трилинейная фильтрация
  - Подходит для: Энтузиастские GPU (RTX 3070/3080/3090/4080/4090, RX 6800/6900)

### Ray Tracing / Трассировка лучей

#### English
Enable ray tracing for realistic lighting and reflections:

**Requirements:**
- NVIDIA RTX GPU (RTX 20, 30, or 40 series)
- OR AMD GPU with ray tracing support (RX 6000/7000 series)
- Updated GPU drivers

**Features:**
- Ray traced reflections (enhanced reflection quality)
- Ray traced shadows (soft, realistic shadows)
- Ray traced ambient occlusion (better contact shadows)
- Ray traced global illumination (realistic light bounce)

**Performance Impact:** High (30-50% FPS reduction)
**Recommended:** Use with DLSS enabled

#### Русский
Включите трассировку лучей для реалистичного освещения и отражений:

**Требования:**
- NVIDIA RTX GPU (RTX 20, 30 или 40 серии)
- ИЛИ AMD GPU с поддержкой трассировки лучей (RX 6000/7000 серии)
- Обновленные драйверы GPU

**Возможности:**
- Трассировка отражений (улучшенное качество отражений)
- Трассировка теней (мягкие, реалистичные тени)
- Трассировка ambient occlusion (лучшие контактные тени)
- Трассировка глобального освещения (реалистичный отскок света)

**Влияние на производительность:** Высокое (снижение FPS на 30-50%)
**Рекомендуется:** Использовать с включенным DLSS

### DLSS Settings / Настройки DLSS

#### English
DLSS (Deep Learning Super Sampling) provides AI-powered upscaling:

**Requirements:**
- NVIDIA RTX GPU (RTX 20, 30, or 40 series)
- Updated GPU drivers

The mod will automatically select Balanced quality mode. DLSS has 5 quality modes:

- **Ultra Performance**: 33% internal resolution → Maximum FPS, lower quality
- **Performance**: 50% internal resolution → High FPS boost, good quality
- **Balanced**: 58% internal resolution → Balanced FPS and quality (recommended)
- **Quality**: 67% internal resolution → Small FPS boost, excellent quality
- **Ultra Quality**: 77% internal resolution → Minimal FPS boost, best quality

**Performance Gain:** 30-100% depending on mode
**Recommended:** Balanced or Quality mode for best experience

#### Русский
DLSS (Deep Learning Super Sampling) обеспечивает апскейлинг с помощью ИИ:

**Требования:**
- NVIDIA RTX GPU (RTX 20, 30 или 40 серии)
- Обновленные драйверы GPU

Мод автоматически выберет режим Balanced. DLSS имеет 5 режимов качества:

- **Ultra Performance**: 33% внутреннего разрешения → Максимальный FPS, низкое качество
- **Performance**: 50% внутреннего разрешения → Высокий прирост FPS, хорошее качество
- **Balanced**: 58% внутреннего разрешения → Сбалансированный FPS и качество (рекомендуется)
- **Quality**: 67% внутреннего разрешения → Небольшой прирост FPS, отличное качество
- **Ultra Quality**: 77% внутреннего разрешения → Минимальный прирост FPS, лучшее качество

**Прирост производительности:** 30-100% в зависимости от режима
**Рекомендуется:** Режим Balanced или Quality для лучшего опыта

### Frame Generation / Генерация кадров

#### English
Frame Generation (DLSS 3) creates additional frames for higher FPS:

**Requirements:**
- NVIDIA RTX 40 series GPU ONLY (RTX 4060/4070/4080/4090)
- Updated GPU drivers
- Base FPS of 60+ recommended

**How it works:**
- Generates intermediate frames using AI
- Can double or triple your frame rate
- Works best with 60+ base FPS
- Default target: 120 FPS

**Performance Gain:** 50-100% (doubles frame rate)
**Best for:** Competitive players, high refresh rate monitors (120Hz+)

#### Русский
Генерация кадров (DLSS 3) создает дополнительные кадры для более высокого FPS:

**Требования:**
- ТОЛЬКО NVIDIA RTX 40 серии GPU (RTX 4060/4070/4080/4090)
- Обновленные драйверы GPU
- Рекомендуется базовый FPS 60+

**Как это работает:**
- Генерирует промежуточные кадры с помощью ИИ
- Может удвоить или утроить частоту кадров
- Работает лучше всего с базовым FPS 60+
- Цель по умолчанию: 120 FPS

**Прирост производительности:** 50-100% (удваивает частоту кадров)
**Лучше всего для:** Соревновательных игроков, мониторов с высокой частотой обновления (120Гц+)

### Render Scale / Масштаб рендеринга

#### English
Render Scale controls the internal rendering resolution:

- **0.5**: Half resolution → Maximum performance, lower quality
- **0.75**: 75% resolution → Good performance boost, decent quality
- **1.0**: Native resolution → No change (default)
- **1.5**: 150% resolution → Better quality, lower FPS
- **2.0**: Double resolution → Maximum quality, significant FPS hit

**Note:** When DLSS is enabled, render scale is automatically managed.

#### Русский
Масштаб рендеринга контролирует внутреннее разрешение рендеринга:

- **0.5**: Половина разрешения → Максимальная производительность, низкое качество
- **0.75**: 75% разрешения → Хороший прирост производительности, приличное качество
- **1.0**: Нативное разрешение → Без изменений (по умолчанию)
- **1.5**: 150% разрешения → Лучшее качество, ниже FPS
- **2.0**: Двойное разрешение → Максимальное качество, значительное снижение FPS

**Примечание:** Когда DLSS включен, масштаб рендеринга управляется автоматически.

## Recommended Configurations / Рекомендуемые конфигурации

### For Maximum Quality / Для максимального качества
```ini
[Graphics]
EnableRayTracing = true
EnableDLSS = true
EnableFrameGeneration = false
TextureQuality = 3
RenderScale = 1.0
```

### For Balanced Performance / Для сбалансированной производительности
```ini
[Graphics]
EnableRayTracing = true
EnableDLSS = true
EnableFrameGeneration = false
TextureQuality = 2
RenderScale = 1.0
```

### For Maximum FPS (RTX 40 series) / Для максимального FPS (RTX 40 серии)
```ini
[Graphics]
EnableRayTracing = false
EnableDLSS = true
EnableFrameGeneration = true
TextureQuality = 2
RenderScale = 1.0
```

### For Lower-End Systems / Для систем начального уровня
```ini
[Graphics]
EnableRayTracing = false
EnableDLSS = false
EnableFrameGeneration = false
TextureQuality = 1
RenderScale = 0.75
```

## Troubleshooting / Устранение неполадок

### Game crashes on startup / Игра вылетает при запуске
**English:** Check BepInEx console for errors. Ensure BepInEx is properly installed.
**Русский:** Проверьте консоль BepInEx на наличие ошибок. Убедитесь, что BepInEx правильно установлен.

### Low FPS with ray tracing / Низкий FPS с трассировкой лучей
**English:** Enable DLSS or disable ray tracing. Ray tracing requires powerful GPU.
**Русский:** Включите DLSS или отключите трассировку лучей. Трассировка лучей требует мощного GPU.

### DLSS not working / DLSS не работает
**English:** Check if you have RTX GPU and latest drivers. Check BepInEx console for warnings.
**Русский:** Проверьте, есть ли у вас RTX GPU и последние драйверы. Проверьте консоль BepInEx на предупреждения.

### Frame Generation not available / Генерация кадров недоступна
**English:** Frame Generation requires RTX 40 series GPU (4060/4070/4080/4090).
**Русский:** Генерация кадров требует GPU RTX 40 серии (4060/4070/4080/4090).

## Support / Поддержка

For issues, please open a GitHub issue with:
- Your system specifications
- BepInEx console log
- Configuration file contents

Для проблем, пожалуйста, откройте GitHub issue с:
- Характеристиками вашей системы
- Логом консоли BepInEx
- Содержимым файла конфигурации
