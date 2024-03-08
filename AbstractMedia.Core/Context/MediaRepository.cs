﻿using System;
using System.Collections.Generic;
using AbstractMedia.Core.Models;

namespace AbstractMedia.Core.Context;

public class MediaRepository : IMediaRepository
{
    private readonly IMediaContext _context;

    public MediaRepository(IMediaContext context)
    {
        _context = context;
    }

    public void AddMedia(Media media)
    {
        _context.AddMedia(media);
        _context.SaveChanges();
    }
    
    public Media FindMedia(string type, string title)
    {
        // Instructions:
        // 1. Loop through each media item in the _context.Media list.
        // 2. For each media item, check if its type matches the 'type' parameter (case-insensitive)
        // and its title matches the 'title' parameter (case-insensitive).
        // 3. If a match is found, return the media item.
        // 4. If no match is found after checking all media items, return null.

        // Your code starts here.
        return _context.Media.Find(
            m => m.GetType().Name.ToLower().Equals(type.ToLower()) 
                 && m.Title.Equals(title)) ?? null;
        
        
    }

    public IEnumerable<Media> GetAllMedia()
    {
        return _context.Media;
    }
}
