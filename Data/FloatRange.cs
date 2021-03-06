﻿using System;
using UnityEngine;

namespace SpaceTrade.Scripts
{
  /// <summary>
  /// Select rng values within a given range.
  /// </summary>
  [Serializable]
  public class FloatRange
  {
    [SerializeField]
    float _minInclusive = 0;

    [SerializeField]
    float _maxInclusive = 0;

    public float minInclusive
    {
      get
      {
        return _minInclusive;
      }
    }

    public float maxInclusive
    {
      get
      {
        return _maxInclusive;
      }
    }

    public float RandomValue()
    {
      return UnityEngine.Random.Range(minInclusive, maxInclusive);
    }

    public static implicit operator float(
      FloatRange range)
    {
      return range.RandomValue();
    }
  }
}
