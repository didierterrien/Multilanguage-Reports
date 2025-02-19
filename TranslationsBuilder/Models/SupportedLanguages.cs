﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace TranslationsBuilder.Models {

  class SupportedLanguages {

    static public Language English = new Language {
      LanguageTag = "en-US",
      TranslationId = "en",
      DisplayName = "English",
      NativeName = "English"
    };

    static public Language Spanish = new Language {
      LanguageTag = "es-ES",
      TranslationId = "es",
      DisplayName = "Spanish",
      NativeName = "español"
    };

    static public Language Portuguese = new Language {
      LanguageTag = "pt-PT",
      TranslationId = "pt",
      DisplayName = "Portuguese",
      NativeName = "Portuguese"
    };

    static public Language French = new Language {
      LanguageTag = "fr-FR",
      TranslationId = "fr",
      DisplayName = "French",
      NativeName = "français"
    };

    static public Language German = new Language {
      LanguageTag = "de-DE",
      TranslationId = "de",
      DisplayName = "German",
      NativeName = "Deutsch"
    };

    static public Language Dutch = new Language {
      LanguageTag = "nl-NL",
      TranslationId = "nl",
      DisplayName = "Dutch",
      NativeName = "Nederlands"
    };

    static public Language Irish = new Language {
      LanguageTag = "ga-IE",
      TranslationId = "ga",
      DisplayName = "Irish",
      NativeName = "Gaeilge"
    };

    static public Language Russian = new Language {
      LanguageTag = "ru-RU",
      TranslationId = "ru",
      DisplayName = "Russian",
      NativeName = "русский"
    };

    static public Language Hebrew = new Language {
      LanguageTag = "he-IL",
      TranslationId = "he",
      DisplayName = "Hebrew",
      NativeName = "עברית"
    };

    static public Language Hindi = new Language {
      LanguageTag = "hi-IN",
      TranslationId = "hi",
      DisplayName = "Hindi",
      NativeName = "हिन्दी"
    };

    static public Language Japanese = new Language {
      LanguageTag = "ja-JP",
      TranslationId = "ja",
      DisplayName = "Japanese",
      NativeName = "日本語"
    };

    static public Language Chinese = new Language {
      LanguageTag = "zh-CN",
      TranslationId = "zh-Hans",
      DisplayName = "Chinese",
      NativeName = "中文"
    };

    static public Dictionary<string, Language> AllLangauges = 
           new Dictionary<string, Language>{
             { English.LanguageTag, English },
             { Spanish.LanguageTag, Spanish },
             { Portuguese.LanguageTag, Portuguese },
             { French.LanguageTag, French },
             { German.LanguageTag, German },
             { Dutch.LanguageTag, Dutch },
             { Irish.LanguageTag, Irish},
             { Russian.LanguageTag, Russian },
             { Hebrew.LanguageTag, Hebrew },
             { Hindi.LanguageTag, Hindi },
             { Japanese.LanguageTag, Japanese },
             { Chinese.LanguageTag, Chinese }
    };

    static public Language GetLanguageFromFullName(string FullName) {
      return AllLangauges.First(languageEntry => languageEntry.Value.FullName == FullName).Value;
    }

  }
}
