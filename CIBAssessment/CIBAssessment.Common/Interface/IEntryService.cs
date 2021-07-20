﻿using System;
using System.Collections.Generic;
using System.Text;
using CIBAssessment.Data.Models;

namespace CIBAssessment.Common.Interface
{
  public interface IEntryService
  {
    List<Entry> GetEntries(int phonebookId);
    List<Entry> getEntry(int phonebookid,string name);

    Entry AddEntry(Entry entry);

    void DeleteEntry(int id);

    void UpdatEntry(int id, Entry entry);

  }
}
