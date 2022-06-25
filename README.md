# Wcs.Random
A simple random data generator

## Usage

Default:

```csharp
var random = new Randomizer();
```

Setting randomizer options:

```csharp
var random = new RandomizerOptions(new CryptoRandomSource());
```

## Randomizers

### Dice

| Method | Description                                            |
|--------|--------------------------------------------------------|
| D2     | Equivalent of flipping a coin                          |
| D4     | Equivalent of rolling a four-sided die                 |
| D6     | Equivalent of rolling a six-sided die                  |
| D8     | Equivalent of rolling a eight-sided die                |
| D10    | Equivalent of rolling a ten-sided die                  |
| D12    | Equivalent of rolling a twelve-sided die               |
| D20    | Equivalent of rolling a twenty-sided die               |
| D100   | Equivalent of rolling a one hundred-sided die          |
| DSides | Equivalent of rolling a die with given number of sides |
