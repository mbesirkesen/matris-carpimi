# Matris Çarpımı

[![CI](https://github.com/mbesirkesen/matris-carpimi/actions/workflows/ci.yml/badge.svg)](https://github.com/mbesirkesen/matris-carpimi/actions/workflows/ci.yml)

Konsol tabanlı bir C# uygulaması. İki kare matrisin (N×N) elemanlarını alır, standart matris çarpımı algoritmasıyla sonucu hesaplar ve ekrana yazdırır.

## Özellikler

- Kare matris çarpımı (N×N)
- Giriş doğrulama ve anlaşılır hata mesajları
- Satır/sütun numarasıyla eleman girişi
- Windows, macOS ve Linux desteği (.NET 8)

## Gereksinimler

- [.NET 8 SDK](https://dotnet.microsoft.com/download)

macOS:

```bash
brew install dotnet
```

## Kurulum ve çalıştırma

```bash
git clone https://github.com/mbesirkesen/matris-carpimi.git
cd matris-carpimi
dotnet run --project MatrisCarpimi/MatrisCarpimi.csproj
```

Derleme:

```bash
dotnet build matris-carpimi.sln --configuration Release
```

## Kullanım

1. Matris boyutunu (N) girin — 1 ile 50 arasında olmalıdır.
2. 1. matrisin elemanlarını `[satır,sütun]` formatında girin.
3. 2. matrisin elemanlarını girin.
4. Çarpım sonucu ekranda gösterilir.

### Örnek

```
Lütfen matrisin boyutunu giriniz (N): 2

1. matris (2x2) değerlerini giriniz:
  [1,1]: 1
  [1,2]: 2
  [2,1]: 3
  [2,2]: 4

2. matris (2x2) değerlerini giriniz:
  [1,1]: 5
  [1,2]: 6
  [2,1]: 7
  [2,2]: 8

Matrisin çarpım sonucu:
19      22
43      50
```

## Proje yapısı

```
matris-carpimi/
├── .github/workflows/ci.yml   # GitHub Actions CI
├── MatrisCarpimi/
│   ├── Program.cs             # Uygulama giriş noktası
│   └── MatrisCarpimi.csproj
├── matris-carpimi.sln
├── global.json
├── .editorconfig
├── .gitignore
└── LICENSE
```

## Algoritma

Standart matris çarpımı: `C[i,j] = Σ A[i,k] × B[k,j]`

## Lisans

[MIT](LICENSE) — Muhammed Besir Kesen
