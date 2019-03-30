﻿namespace AutoBogus.Conventions
{
  internal interface IAutoConventionGenerator
  {
    bool CanGenerate(AutoGenerateContext context);

    object Generate(AutoGenerateContext context);
  }
}