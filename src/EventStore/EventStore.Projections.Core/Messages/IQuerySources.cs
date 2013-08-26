// Copyright (c) 2012, Event Store LLP
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without
// modification, are permitted provided that the following conditions are
// met:
// 
// Redistributions of source code must retain the above copyright notice,
// this list of conditions and the following disclaimer.
// Redistributions in binary form must reproduce the above copyright
// notice, this list of conditions and the following disclaimer in the
// documentation and/or other materials provided with the distribution.
// Neither the name of the Event Store LLP nor the names of its
// contributors may be used to endorse or promote products derived from
// this software without specific prior written permission
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS
// "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT
// LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR
// A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT
// HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL,
// SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT
// LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
// DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY
// THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
// (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
// OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
// 

namespace EventStore.Projections.Core.Messages
{
    public interface IQuerySources
    {
        bool AllStreams { get; }

        string[] Categories { get; }

        string[] Streams { get; }

        bool AllEvents { get; }

        string[] Events { get; }

        bool ByStreams { get; }

        bool ByCustomPartitions { get; }

        bool DefinesStateTransform { get; }

        bool OutputRunningResults { get; }

        bool IncludeLinksOption { get; }

        string ResultStreamNameOption { get; }

        string PartitionResultStreamNamePatternOption { get; }

        string ForceProjectionNameOption { get; }

        bool ReorderEventsOption { get; }

        int? ProcessingLagOption { get; }
    }

    public static class QuerySourcesExtensions
    {
        public static bool HasStreams(this IQuerySources sources)
        {
            var streams = sources.Streams;
            return streams != null && streams.Length > 0;
        }

        public static bool HasCategories(this IQuerySources sources)
        {
            var categories = sources.Categories;
            return categories != null && categories.Length > 0;
        }

        public static bool HasEvents(this IQuerySources sources)
        {
            var events = sources.Events;
            return events != null && events.Length > 0;
        }
    }
}
