﻿using System;

namespace CanHazFunny;

public class Jester
{
    private IJokeService? _JokeService;

    public IJokeService JokeService
    {
        get { return _JokeService!; }
        set
        {
            _JokeService = value ?? throw new ArgumentNullException(nameof(value));
        }
    }

    private IOutJoke? _OutService;
    public IOutJoke OutService
    {
        get { return _OutService!; }
        set
        {
            _OutService = value ?? throw new ArgumentNullException(nameof(value));
        }
    }

    public Jester(IJokeService jokeService, IOutJoke outService)
    {
        JokeService = jokeService;
        OutService = outService;
    }

    public virtual void TellJoke()
    {
        string joke;
        do{
            joke = JokeService.GetJoke();
        }while(joke.Contains("Chuck Norris"));
        OutService.DisplayJoke(joke);
    }


}

