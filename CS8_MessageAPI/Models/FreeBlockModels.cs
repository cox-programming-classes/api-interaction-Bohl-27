using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// An Academic Block
/// </summary>
/// <param name="blockId">don't care</param>
/// <param name="name">name of the block</param>
/// <param name="schoolLevel">Upper or Lower School</param>
public record Block(
    string blockId,
    string name,
    string schoolLevel);
/// <summary>
/// Time period that you're free
/// </summary>
/// <param name="start">when the free block starts</param>
/// <param name="end">when the free block ends</param>
/// <param name="block">block information</param>
public record FreeBlock(
    DateTime start,
    DateTime end,
    Block block);
/// <summary>
/// Collection of Freeblocks
/// Response to a request for free-blocks in a given range of dates
/// </summary>
/// <param name="freeBlocks"></param>
/// <param name="inRange"></param>
public record FreeBlockCollection(
    FreeBlock[] freeBlocks,
    DateOnly[] inRange);
