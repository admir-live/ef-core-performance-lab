# EF Core Performance Lab

Welcome to the EF Core Performance Lab! This repository is dedicated to exploring and benchmarking the performance of Entity Framework Core (EF Core) with a focus on query optimization techniques such as `AsSplitQuery()`.

## Overview

Entity Framework Core is a powerful ORM for .NET applications, but it requires careful consideration to optimize for performance. This lab demonstrates the use of `AsSplitQuery()` to mitigate Cartesian explosions in queries involving one-to-many relationships, especially with large datasets.

## Features

- Examples of `AsSplitQuery()` to optimize complex queries.
- Benchmarks comparing `AsSplitQuery()` against traditional `Include()` methods.
- Demonstrations of scenarios where `AsSplitQuery()` may not be the best choice.

## Getting Started

To get started with this project, clone the repository to your local machine:

```bash
git clone https://github.com/admir-live/ef-core-performance-lab.git
