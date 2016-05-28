/**
Copyright 2011, Cong Nguyen

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

   http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
**/
#include "Configuration.h"
#include "Block.h"
#include "Paragraph.h"

BEGIN_NAMSPACE

USING_COMMON_SYSTEM


Block::Block()
{
	_paragraphs = new List<Paragraph*>();

	_pageLevel = ePageLevel::RIL_BLOCK;

	_color = System::Drawing::Color::SkyBlue;
}

Block::~Block()
{
}


END_NAMESPACE