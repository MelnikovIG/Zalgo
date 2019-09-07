# Zalgo
Zalgo is a library that can convert you text to zalgo. Zalgo is a spiled text wth special symbols. For example text `brown fox jumping over lazy dog` can be converted to `b̛̕ŗ̢ơ̧wn ̵͝͏f̨̕ó̕x̛͠ ̕j̡́ưm̨͜͞p̷̀͝i͘͜n͘g̴ o̶͟͠v̕e͢͝r l҉͞ą́͜zy ̸̧͜d̨́ǫ̛g̡`

# Using
You can add Zalgo using nuget <a href="https://www.nuget.org/packages/Zalgo/" rel="nofollow"><img alt="Nuget" src="https://img.shields.io/nuget/v/Zalgo"></a>

Create `ZalgoString` options:
- use constructor `new ZalgoString("you text")`
- use implicit cast `ZalgoString zalgoString = "you text";`

Get `string` value of `ZalgoString` options:
- use `ToString()` `new ZalgoString("you text").ToString()`
- via implicit cast `string zalgoStr = new ZalgoString("you text")`

# Options
There is 2 configuration options for creating zalgo string

* `FuckUpMode` enum defines spoilage level
  * `Min` minimum level `b͡row̸n f̧ox̕ ju͘mpin̡g ̡over la͟zy dog`
  * `Normal` mormal level `b͡r͟ò̴̵w͜n ̛fox̀͡͠ ̡j̡͠͝u̶m̶͏pi͜n̡̛g͘ ̵o̵͘͘v͞è̴ŕ̶̕ ̴̶́la̛zy̧̢̧ ̡d̡og`
  * `Max` maximum level `b̢̕͜r̶ó̡́̕͞wņ̡͏ f̸̡̛͠͞o̧x̸̀ ̷̀͡͞͠jú̷̢͞m̧̢͜͏pì̶̡͢n͏̶̷̡̨ģ̵̡̕͞ ǫ̷̛͞v͟͡ȩ̴̴͡r͟ ͠l͏͢͟a͘҉ź͠y ̡̧͜d͞҉̕òg̷̵̡̡͡`

* `FuckUpPosition` flag enum defines spoilage position (can be combined)
  * `Up` up position `b͐̃ͧͨ̒̏̓̆ͨr̉̑̊ͤo͒̿͑̈́͌w͛̂̔ͦ̒̔n̽̂̈́͐ͥ ́̅̍̐̑̏f̃̐̈̿͋͗ͦo͒̽̔͌x̄ ̃jͫ́ͩ̎u̽̓͑͋̈̾̊̇mͯ̅̔ͭ̽ṕ̽̓́͛ͤ͂̎i͋ͥͩ̓͛ngͫͭ͊ ̃̾ͬö́͑̎̅̇̉̾ͯͦv͋̆ͥ̽ͬe̽ͦͧͤr͌ ̾ͭͦ͐̑ͯl͊͂̍̊̇̔ͯ͊̐aͩ͑͂̒̃͂ͬz̓͑ͨ̉ͨyͣͮ͐̄ͬ͊ ́ͤͫ̈ͪ̌͊dͬo͌̓ͨ̾ͧ͐gͣ̀̅̐ͮ`

  * `Bot` bot position `b̲̭͇͇̯r̹̬̹̯̻̞͙o̥̩̜̟ͅwn͕ ͉̥f̘͎̘͕̯̳͎̰͍ox̺͓ ̥̬̖̺̺͇j͔͖ṵ̮̥͎̼̺̥m̟̞̱̺̻̺͙͓͓p͍̯̦͈̗̙i̤n͉̫̖͈̺̪̦g̯̟͕̙ ov̲͙̳̟͇̫͓e͓͕̥͖̙̤̝̭̳r̳̞̖̹̣̘̠͖ ̳la̟̮̲̤̘̠̭z̞̼̤͕͈͇̫y̫ d̮̦̠̣͎͓ͅo̪̜g̙̮͉͓͈̠͎͍̯`
    
  * `Middle` middle position `b̢͝r̀ò̧w͘͢n̕ ̶́fo̕x j̕͟ưm̢͢p̕͜ing̸͜͡ ov̷͘e̴r̶̨ la͞z̷y̧̨͠ ̶͘͝d̀͜͠og̴̵̨`
  
  * `All` all position `b̤̹̰̩͓͎ͯ͗ͫ̍̉̑̐ͭ̍́ͅr̝̣̟̹͉̣̅ͥ̑͒̑ͦͅọ͝w̤͇̱̞̝̎̋̔͑͂̕n̵͓̹̯̺̭͎͑̅ͣͭͮ͛͡ ͎͈͖͚̯̖̯̙͒ͥ͑̎͗̌ͯf̶̜̜̎ͮ̅̒o͙̪̺̖̺͉̙ͣ̓̃͛̂̈́̾x͎̝̫̞̂ ̰͚̗̼̰̞̆ͥ̏͑̿ͮ̌̃͗̀̀j̵́҉̭̮u̢̬͇̤͇̳̟̳̣ͮ͌́̽ͬ̓͝ḿ̴̻̠̙̞̦p̵̡̱͍̹̯̺̼͈̐ͧ͜i͓̙͇̥n̮̯̹ͪ̑̇ͥ̊͗g̡͙͍̮̣͉̭̺ͅ ̨̖͓̠̹̝̣̆́ͧ̈̅̒͛͊ͥ͢͡o̸̰̗̻͘v̴̬̖̙͚̜̭̖̮̒ͤͫ̇̋̓ͥ͘e̦̦͙͒̈̔̾ͅṟ̝̙̘ͫ͌ ͚̹̌͘l̛̮̰̺̠a̼̘̜͚͚̝̓̿ͭ̾̊z̓ͯ̓͛ͮ͛҉̩̗͚͎͔͕̤͎̹yͫͩ҉̞̝ ̅҉͕͎͚̙͝d̼̖͑̀͝o̴̸̩͠ģ̟͎̫̹͖̩̬̘͋̒̐͠`
  
# Dont forget!
Make ͢som̶e ́f͡un ͏w̶it́h̷ Z͡a̷lgo̡ ̴t͞e̕x̷t
